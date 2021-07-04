using CmslCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace Minecraft_Server_Actuator
{
    public partial class Minecraft_Server_Actuator : Form
    {
        CmslServer server;
        CmslServer serverKill;
        public static config config = new config();

        List<string> commandList = new List<string>();
        int commandListIndex = 0;

        int serverTimer_hour = 0;
        int serverTimer_minute = 0;
        int serverTimer_second = -1;

        bool temp = false;
        new bool Close = false;

        public Color LightColor;
        public Color LightDarkColor;
        public Color LightButtonColor;
        public Color LightTextColor;

        public Color DarkColor;
        public Color DarkDarkColor;
        public Color DarkButtonColor;
        public Color DarkTextColor;

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");

        public Minecraft_Server_Actuator()
        {
            InitializeComponent();

            Load += TrayIcon_Load;

            LightColor = Color.FromArgb(255, 255, 255);
            LightDarkColor = Color.FromArgb(240, 240, 240);
            LightButtonColor = Color.FromArgb(250, 250, 250);
            LightTextColor = Color.Black;

            DarkColor = Color.FromArgb(32, 32, 32);
            DarkDarkColor = Color.FromArgb(25, 25, 25);
            DarkButtonColor = Color.FromArgb(93, 93, 93);
            DarkTextColor = Color.White;

            FormClosing += new FormClosingEventHandler(Minecraft_Server_Actuator_FormClosing);
            string jsonText = "";
            string tempAutoStartPath = config.AutoStartPath;
            int tempRam = config.Ram;
            string tempServerName = config.ServerName;
            string tempServerReloadCommand = config.ServerReloadCommand;
            string tempServerDatapackReloadCommand = config.ServerDatapackReloadCommand;
            string tempServerStopCommand = config.ServerStopCommand;
            string tempTaskkillCommand = config.TaskkillCommand;
            bool tempShow_the_authorship_of_the_dll_and_package_file_used_in_the_log = config.Show_the_authorship_of_the_dll_and_package_file_used_in_the_log;

            if (File.Exists(Path.Combine(Application.StartupPath, "config.json")))
            {
                jsonText = File.ReadAllText(Path.Combine(Application.StartupPath, "config.json"));
                config = JsonConvert.DeserializeObject<config>(jsonText);
            }
            else
            {
                jsonText = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(Path.Combine(Application.StartupPath, "config.json"), jsonText);
            }

            if (tempAutoStartPath != "")
                config.AutoStartPath = tempAutoStartPath;
            if (tempRam != 1)
                config.Ram = tempRam;
            if (tempServerName != "server")
                config.ServerName = tempServerName;
            if (tempServerReloadCommand != "reload")
                config.ServerReloadCommand = tempServerReloadCommand;
            if (tempServerDatapackReloadCommand != "minecraft:reload")
                config.ServerDatapackReloadCommand = tempServerDatapackReloadCommand;
            if (tempServerStopCommand != "stop")
                config.ServerStopCommand = tempServerStopCommand;
            if (tempTaskkillCommand != "taskkill /f /im java.exe")
                config.TaskkillCommand = tempTaskkillCommand;

            server = new CmslServer($"java -Xms{config.Ram}G -Xmx{config.Ram}G -XX:+UseG1GC -XX:+ParallelRefProcEnabled -XX:MaxGCPauseMillis=200 -XX:+UnlockExperimentalVMOptions -XX:+DisableExplicitGC -XX:+AlwaysPreTouch -XX:G1NewSizePercent=40 -XX:G1MaxNewSizePercent=50 -XX:G1HeapRegionSize=16M -XX:G1ReservePercent=15 -XX:G1HeapWastePercent=5 -XX:G1MixedGCCountTarget=4 -XX:InitiatingHeapOccupancyPercent=20 -XX:G1MixedGCLiveThresholdPercent=90 -XX:G1RSetUpdatingPauseTimePercent=5 -XX:SurvivorRatio=32 -XX:+PerfDisableSharedMem -XX:MaxTenuringThreshold=1 -Dusing.aikars.flags=https://mcflags.emc.gs -Daikars.new.flags=true -jar {config.ServerName}.jar nogui");
            server.OutputTextChangeEvent += server_OutputTextChangeEvent;

            serverKill = new CmslServer(config.TaskkillCommand);

            if (config.Show_the_authorship_of_the_dll_and_package_file_used_in_the_log)
                log.Text = $"Minecraft Server Actuator by. Simsimhan Chobo (https://github.com/SimsimhanChobo/Minecraft-Server-Actuator) {Environment.NewLine}CmslCoreLib.dll by. 슈퍼코믹 (https://blog.naver.com/ekfvoddl3535/221650680627) {Environment.NewLine}Newtonsoft.Json.dll by. James Newton-King (https://github.com/JamesNK/Newtonsoft.Json)" + Environment.NewLine + Environment.NewLine;

            GetWindowsColor();

            if (config.GUIHide)
            {
                Opacity = 0;
                ShowInTaskbar = false;
                GUIToggleToolStripMenuItem.Text = "GUI 보이기";
                GUIToggle_button.Text = "GUI 보이기";
            }

            /*log.Text += $"Ram: {config.Ram}{Environment.NewLine}";
            log.Text += $"Server Name: {config.ServerName}{Environment.NewLine}";
            log.Text += $"Server Reload Command: {config.ServerReloadCommand}{Environment.NewLine}";
            log.Text += $"Server Datapack Reload Command: {config.ServerDatapackReloadCommand}{Environment.NewLine}";
            log.Text += $"Server Stop Command: {config.ServerStopCommand}{Environment.NewLine}";
            log.Text += $"Taskkill Command: {config.TaskkillCommand}{Environment.NewLine}";*/

            if (config.AutoStartPath != "")
                ServerOn(config.AutoStartPath);
        }

        public void TrayIcon_Load(object sender, EventArgs e) => trayicon.ContextMenuStrip = context_trayicon;

        void ServerOn(string path = "")
        {
            if (!server.IsRunning)
            {
                if (path != "")
                {
                    if (File.Exists(Path.Combine(config.AutoStartPath, config.ServerName + ".jar")))
                    {
                        server.Start(config.AutoStartPath);
                        server_off_button.Enabled = true;
                        server_on_button.Enabled = false;
                        server_kill_button.Enabled = true;
                        server_reload_button.Enabled = true;
                        server_datapack_reload_button.Enabled = true;
                        command.Enabled = true;

                        tick_1000.Enabled = true;
                        tick_1000.Start();
                        server_on_time_text.Text = "구동 시간 0:00:00";
                    }
                    else
                        log.Text += $"\nCould not find file \"{Path.Combine(config.AutoStartPath, config.ServerName + ".jar")}\"";
                }
                else
                {
                    server_on_folder_path.ShowDialog();

                    if (File.Exists(Path.Combine(server_on_folder_path.SelectedPath, config.ServerName + ".jar")))
                    {
                        server.Start(server_on_folder_path.SelectedPath);
                        server_off_button.Enabled = true;
                        server_on_button.Enabled = false;
                        server_kill_button.Enabled = true;
                        server_reload_button.Enabled = true;
                        server_datapack_reload_button.Enabled = true;
                        command.Enabled = true;

                        tick_1000.Enabled = true;
                        tick_1000.Start();
                        server_on_time_text.Text = "구동 시간 0:00:00";
                    }
                    else
                        log.Text += $"{Environment.NewLine}Could not find file \"{Path.Combine(server_on_folder_path.SelectedPath, config.ServerName + ".jar")}\"";
                }
            }
        }

        private void server_OutputTextChangeEvent(object sender, string e)
        {
            if (temp)
                Invoke((Action)delegate { log.AppendText(Environment.NewLine + e); });
            else
                Invoke((Action)delegate { log.AppendText(e); });

            temp = true;
        }

        private void server_on_button_Click(object sender, EventArgs e) => ServerOn();

        void ServerOff()
        {
            server.StdInput(config.ServerStopCommand);
            server_off_button.Enabled = false;
            server_reload_button.Enabled = false;
            server_datapack_reload_button.Enabled = false;
            command.Enabled = false;
        }

        private void server_off_button_Click(object sender, EventArgs e) => ServerOff();

        void Cmd()
        {
            server.StdInput(command.Text);
            if (temp)
                log.Text += Environment.NewLine + ">" + command.Text;
            else
                log.Text += command.Text;
            command.Text = "";

            temp = true;
        }

        private void server_reload_button_Click(object sender, EventArgs e) => server.StdInput(config.ServerReloadCommand);

        private void server_datapack_reload_button_Click(object sender, EventArgs e) => server.StdInput(config.ServerDatapackReloadCommand);

        void Minecraft_Server_Actuator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server.IsRunning)
            {
                if (!Close)
                {
                    DialogResult message = MessageBox.Show("서버를 강제로 종료하시겠습니까?", "강제 종료", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (message == DialogResult.Yes)
                        serverKill.Start("");
                    else if (message == DialogResult.No)
                    {
                        server.StdInput(config.ServerStopCommand);
                        server_off_button.Enabled = false;
                        server_reload_button.Enabled = false;
                        server_datapack_reload_button.Enabled = false;
                        command.Enabled = false;

                        Close = true;
                        e.Cancel = true;
                    }
                    else if (message == DialogResult.Cancel)
                        e.Cancel = true;
                }
                else
                {
                    DialogResult message = MessageBox.Show("서버를 강제로 종료하시겠습니까?", "강제 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (message == DialogResult.Yes)
                        serverKill.Start("");
                    else
                        e.Cancel = true;
                }
            }

            if (!e.Cancel)
            {
                string jsonText = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(Path.Combine(Application.StartupPath, "config.json"), jsonText);
            }
        }

        private void server_kill_button_Click(object sender, EventArgs e) => ServerKill();

        void ServerKill()
        {
            DialogResult message = MessageBox.Show("서버를 강제로 종료하시겠습니까?", "강제 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                serverKill.Start("");
                server_off_button.Enabled = false;
                server_on_button.Enabled = true;
                server_kill_button.Enabled = false;
                server_reload_button.Enabled = false;
                server_datapack_reload_button.Enabled = false;
                command.Enabled = false;

                tick_1000.Enabled = false;
                tick_1000.Stop();
            }
        }

        private void command_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && commandListIndex > 0)
            {
                commandListIndex--;
                command.Text = commandList[commandListIndex];
            }
            else if (e.KeyCode == Keys.Down && commandListIndex < commandList.Count - 1)
            {
                commandListIndex++;
                command.Text = commandList[commandListIndex];
            }
        }

        private void command_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                commandList.Add(command.Text);
                commandListIndex = commandList.Count;
                e.Handled = true;
                Cmd();
            }
        }

        private void tick_1000_Tick(object sender, EventArgs e)
        {
            if (!server.IsRunning)
            {
                server_off_button.Enabled = false;
                server_on_button.Enabled = true;
                server_kill_button.Enabled = false;
                server_reload_button.Enabled = false;
                server_datapack_reload_button.Enabled = false;
                command.Enabled = false;

                tick_1000.Enabled = false;
                tick_1000.Stop();

                if (Close)
                    Close();
            }

            serverTimer_second++;

            if (serverTimer_second >= 60)
            {
                serverTimer_second = 0;
                serverTimer_minute++;
            }

            if (serverTimer_minute >= 60)
            {
                serverTimer_minute = 0;
                serverTimer_hour++;
            }

            server_on_time_text.Text = "구동 시간 " + serverTimer_hour;
            if (serverTimer_minute < 10)
                server_on_time_text.Text += ":0" + serverTimer_minute;
            else
                server_on_time_text.Text += ":" + serverTimer_minute;
            if (serverTimer_second < 10)
                server_on_time_text.Text += ":0" + serverTimer_second;
            else
                server_on_time_text.Text += ":" + serverTimer_second;
        }

        private void color_change_Tick(object sender, EventArgs e) => GetWindowsColor();

        private void darktheme_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            config.Dark = darktheme_checkbox.Checked;
            colorChange();
        }

        void GetWindowsColor()
        {
            if (registryKey != null && registryKey.GetValue("AppsUseLightTheme") != null)
            {
                config.Dark = registryKey.GetValue("AppsUseLightTheme").ToString() != "1";

                color_change.Enabled = false;
                color_change.Stop();
                darktheme_checkbox.Visible = false;

                colorChange();
            }
            else
            {
                color_change.Enabled = true;
                color_change.Start();
                darktheme_checkbox.Visible = true;

                colorChange();
            }
        }

        void colorChange()
        {
            darktheme_checkbox.Checked = config.Dark;

            if (config.Dark)
            {
                BackColor = DarkDarkColor;
                ForeColor = DarkTextColor;
                log.BackColor = DarkColor;
                log.ForeColor = DarkTextColor;
                command.BackColor = DarkColor;
                command.ForeColor = DarkTextColor;

                server_on_button.BackColor = DarkButtonColor;
                server_off_button.BackColor = DarkButtonColor;
                server_kill_button.BackColor = DarkButtonColor;
                server_reload_button.BackColor = DarkButtonColor;
                server_datapack_reload_button.BackColor = DarkButtonColor;
                GUIToggle_button.BackColor = DarkButtonColor;

                server_on_button.UseVisualStyleBackColor = false;
                server_off_button.UseVisualStyleBackColor = false;
                server_kill_button.UseVisualStyleBackColor = false;
                server_reload_button.UseVisualStyleBackColor = false;
                server_datapack_reload_button.UseVisualStyleBackColor = false;
                GUIToggle_button.UseVisualStyleBackColor = false;
            }
            else
            {
                BackColor = LightDarkColor;
                ForeColor = LightTextColor;
                log.BackColor = LightColor;
                log.ForeColor = LightTextColor;
                command.BackColor = LightColor;
                command.ForeColor = LightTextColor;

                server_on_button.BackColor = LightButtonColor;
                server_off_button.BackColor = LightButtonColor;
                server_kill_button.BackColor = LightButtonColor;
                server_reload_button.BackColor = LightButtonColor;
                server_datapack_reload_button.BackColor = LightButtonColor;
                GUIToggle_button.BackColor = LightButtonColor;

                server_on_button.UseVisualStyleBackColor = true;
                server_off_button.UseVisualStyleBackColor = true;
                server_kill_button.UseVisualStyleBackColor = true;
                server_reload_button.UseVisualStyleBackColor = true;
                server_datapack_reload_button.UseVisualStyleBackColor = true;
                GUIToggle_button.UseVisualStyleBackColor = true;
            }
        }

        private void 서버켜기ToolStripMenuItem_Click(object sender, EventArgs e) => ServerOn();

        private void 서버끄기ToolStripMenuItem_Click(object sender, EventArgs e) => ServerOff();

        private void 서버강제종료ToolStripMenuItem_Click(object sender, EventArgs e) => ServerKill();

        private void 서버리로드ToolStripMenuItem_Click(object sender, EventArgs e) => server.StdInput(config.ServerReloadCommand);

        private void 서버데이터팩리로드ToolStripMenuItem_Click(object sender, EventArgs e) => server.StdInput(config.ServerDatapackReloadCommand);

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void GUIToggleToolStripMenuItem_Click(object sender, EventArgs e) => GUIToggle();

        void GUIToggle()
        {
            config.GUIHide = !config.GUIHide;

            if (config.GUIHide)
            {
                Opacity = 0;
                ShowInTaskbar = false;
                GUIToggleToolStripMenuItem.Text = "GUI 보이기";
                GUIToggle_button.Text = "GUI 보이기";
            }
            else
            {
                Opacity = 100;
                ShowInTaskbar = true;
                GUIToggleToolStripMenuItem.Text = "GUI 숨기기";
                GUIToggle_button.Text = "GUI 숨기기";
            }
        }

        private void GUIToggle_button_Click(object sender, EventArgs e) => GUIToggle();
    }

    public class config
    {
        public string AutoStartPath = "";
        public int Ram = 1;
        public string ServerName = "server";
        public string ServerStopCommand = "stop";
        public string ServerReloadCommand = "reload";
        public string ServerDatapackReloadCommand = "minecraft:reload";
        public string TaskkillCommand = "taskkill /f /im java.exe";
        public bool Show_the_authorship_of_the_dll_and_package_file_used_in_the_log = true;
        public bool Dark = false;
        public bool GUIHide = false;
    }
}
