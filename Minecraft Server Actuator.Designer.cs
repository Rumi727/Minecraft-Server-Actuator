
namespace Minecraft_Server_Actuator
{
    partial class Minecraft_Server_Actuator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minecraft_Server_Actuator));
            this.log = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.server_on_button = new System.Windows.Forms.Button();
            this.server_off_button = new System.Windows.Forms.Button();
            this.server_reload_button = new System.Windows.Forms.Button();
            this.server_datapack_reload_button = new System.Windows.Forms.Button();
            this.server_kill_button = new System.Windows.Forms.Button();
            this.tick_1000 = new System.Windows.Forms.Timer(this.components);
            this.server_on_time_text = new System.Windows.Forms.Label();
            this.server_on_folder_path = new System.Windows.Forms.FolderBrowserDialog();
            this.color_change = new System.Windows.Forms.Timer(this.components);
            this.darktheme_checkbox = new System.Windows.Forms.CheckBox();
            this.trayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.context_trayicon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.서버켜기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버끄기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버강제종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버리로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버데이터팩리로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GUIToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GUIToggle_button = new System.Windows.Forms.Button();
            this.context_trayicon.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.BackColor = System.Drawing.SystemColors.Window;
            this.log.Location = new System.Drawing.Point(12, 12);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(564, 341);
            this.log.TabIndex = 1;
            // 
            // command
            // 
            this.command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command.Enabled = false;
            this.command.Location = new System.Drawing.Point(12, 359);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(564, 23);
            this.command.TabIndex = 0;
            this.command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_KeyDown);
            this.command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.command_KeyPress);
            // 
            // server_on_button
            // 
            this.server_on_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.server_on_button.Location = new System.Drawing.Point(582, 12);
            this.server_on_button.Name = "server_on_button";
            this.server_on_button.Size = new System.Drawing.Size(145, 23);
            this.server_on_button.TabIndex = 2;
            this.server_on_button.Text = "서버 켜기";
            this.server_on_button.Click += new System.EventHandler(this.server_on_button_Click);
            // 
            // server_off_button
            // 
            this.server_off_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.server_off_button.Enabled = false;
            this.server_off_button.Location = new System.Drawing.Point(582, 41);
            this.server_off_button.Name = "server_off_button";
            this.server_off_button.Size = new System.Drawing.Size(145, 23);
            this.server_off_button.TabIndex = 3;
            this.server_off_button.Text = "서버 끄기";
            this.server_off_button.Click += new System.EventHandler(this.server_off_button_Click);
            // 
            // server_reload_button
            // 
            this.server_reload_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.server_reload_button.Enabled = false;
            this.server_reload_button.Location = new System.Drawing.Point(582, 70);
            this.server_reload_button.Name = "server_reload_button";
            this.server_reload_button.Size = new System.Drawing.Size(145, 23);
            this.server_reload_button.TabIndex = 5;
            this.server_reload_button.Text = "서버 리로드";
            this.server_reload_button.Click += new System.EventHandler(this.server_reload_button_Click);
            // 
            // server_datapack_reload_button
            // 
            this.server_datapack_reload_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.server_datapack_reload_button.Enabled = false;
            this.server_datapack_reload_button.Location = new System.Drawing.Point(582, 99);
            this.server_datapack_reload_button.Name = "server_datapack_reload_button";
            this.server_datapack_reload_button.Size = new System.Drawing.Size(145, 23);
            this.server_datapack_reload_button.TabIndex = 6;
            this.server_datapack_reload_button.Text = "서버 데이터 팩 리로드";
            this.server_datapack_reload_button.Click += new System.EventHandler(this.server_datapack_reload_button_Click);
            // 
            // server_kill_button
            // 
            this.server_kill_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.server_kill_button.Enabled = false;
            this.server_kill_button.ForeColor = System.Drawing.Color.Red;
            this.server_kill_button.Location = new System.Drawing.Point(582, 358);
            this.server_kill_button.Name = "server_kill_button";
            this.server_kill_button.Size = new System.Drawing.Size(145, 23);
            this.server_kill_button.TabIndex = 4;
            this.server_kill_button.Text = "서버 강제 종료";
            this.server_kill_button.Click += new System.EventHandler(this.server_kill_button_Click);
            // 
            // tick_1000
            // 
            this.tick_1000.Enabled = true;
            this.tick_1000.Interval = 1000;
            this.tick_1000.Tick += new System.EventHandler(this.tick_1000_Tick);
            // 
            // server_on_time_text
            // 
            this.server_on_time_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.server_on_time_text.AutoSize = true;
            this.server_on_time_text.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.server_on_time_text.Location = new System.Drawing.Point(582, 332);
            this.server_on_time_text.Name = "server_on_time_text";
            this.server_on_time_text.Size = new System.Drawing.Size(139, 21);
            this.server_on_time_text.TabIndex = 7;
            this.server_on_time_text.Text = "구동 시간 0:00:00";
            // 
            // server_on_folder_path
            // 
            this.server_on_folder_path.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // color_change
            // 
            this.color_change.Enabled = true;
            this.color_change.Interval = 5000;
            this.color_change.Tick += new System.EventHandler(this.color_change_Tick);
            // 
            // darktheme_checkbox
            // 
            this.darktheme_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.darktheme_checkbox.AutoSize = true;
            this.darktheme_checkbox.Location = new System.Drawing.Point(582, 310);
            this.darktheme_checkbox.Name = "darktheme_checkbox";
            this.darktheme_checkbox.Size = new System.Drawing.Size(78, 19);
            this.darktheme_checkbox.TabIndex = 8;
            this.darktheme_checkbox.Text = "다크 모드";
            this.darktheme_checkbox.UseVisualStyleBackColor = true;
            this.darktheme_checkbox.CheckedChanged += new System.EventHandler(this.darktheme_checkbox_CheckedChanged);
            // 
            // trayicon
            // 
            this.trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayicon.Icon")));
            this.trayicon.Text = "Minecraft Server Actuator";
            this.trayicon.Visible = true;
            // 
            // context_trayicon
            // 
            this.context_trayicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.서버켜기ToolStripMenuItem,
            this.서버끄기ToolStripMenuItem,
            this.서버강제종료ToolStripMenuItem,
            this.서버리로드ToolStripMenuItem,
            this.서버데이터팩리로드ToolStripMenuItem,
            this.GUIToggleToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.context_trayicon.Name = "contextMenuStrip1";
            this.context_trayicon.Size = new System.Drawing.Size(195, 158);
            // 
            // 서버켜기ToolStripMenuItem
            // 
            this.서버켜기ToolStripMenuItem.Name = "서버켜기ToolStripMenuItem";
            this.서버켜기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.서버켜기ToolStripMenuItem.Text = "서버 켜기";
            this.서버켜기ToolStripMenuItem.Click += new System.EventHandler(this.서버켜기ToolStripMenuItem_Click);
            // 
            // 서버끄기ToolStripMenuItem
            // 
            this.서버끄기ToolStripMenuItem.Name = "서버끄기ToolStripMenuItem";
            this.서버끄기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.서버끄기ToolStripMenuItem.Text = "서버 끄기";
            this.서버끄기ToolStripMenuItem.Click += new System.EventHandler(this.서버끄기ToolStripMenuItem_Click);
            // 
            // 서버강제종료ToolStripMenuItem
            // 
            this.서버강제종료ToolStripMenuItem.Name = "서버강제종료ToolStripMenuItem";
            this.서버강제종료ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.서버강제종료ToolStripMenuItem.Text = "서버 강제 종료";
            this.서버강제종료ToolStripMenuItem.Click += new System.EventHandler(this.서버강제종료ToolStripMenuItem_Click);
            // 
            // 서버리로드ToolStripMenuItem
            // 
            this.서버리로드ToolStripMenuItem.Name = "서버리로드ToolStripMenuItem";
            this.서버리로드ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.서버리로드ToolStripMenuItem.Text = "서버 리로드";
            this.서버리로드ToolStripMenuItem.Click += new System.EventHandler(this.서버리로드ToolStripMenuItem_Click);
            // 
            // 서버데이터팩리로드ToolStripMenuItem
            // 
            this.서버데이터팩리로드ToolStripMenuItem.Name = "서버데이터팩리로드ToolStripMenuItem";
            this.서버데이터팩리로드ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.서버데이터팩리로드ToolStripMenuItem.Text = "서버 데이터 팩 리로드";
            this.서버데이터팩리로드ToolStripMenuItem.Click += new System.EventHandler(this.서버데이터팩리로드ToolStripMenuItem_Click);
            // 
            // GUIToggleToolStripMenuItem
            // 
            this.GUIToggleToolStripMenuItem.Name = "GUIToggleToolStripMenuItem";
            this.GUIToggleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.GUIToggleToolStripMenuItem.Text = "GUI 숨기기";
            this.GUIToggleToolStripMenuItem.Click += new System.EventHandler(this.GUIToggleToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // GUIToggle_button
            // 
            this.GUIToggle_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GUIToggle_button.Location = new System.Drawing.Point(582, 128);
            this.GUIToggle_button.Name = "GUIToggle_button";
            this.GUIToggle_button.Size = new System.Drawing.Size(145, 23);
            this.GUIToggle_button.TabIndex = 9;
            this.GUIToggle_button.Text = "GUI 숨기기";
            this.GUIToggle_button.UseVisualStyleBackColor = true;
            this.GUIToggle_button.Click += new System.EventHandler(this.GUIToggle_button_Click);
            // 
            // Minecraft_Server_Actuator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 394);
            this.Controls.Add(this.GUIToggle_button);
            this.Controls.Add(this.darktheme_checkbox);
            this.Controls.Add(this.server_on_time_text);
            this.Controls.Add(this.server_kill_button);
            this.Controls.Add(this.server_datapack_reload_button);
            this.Controls.Add(this.server_reload_button);
            this.Controls.Add(this.server_off_button);
            this.Controls.Add(this.server_on_button);
            this.Controls.Add(this.command);
            this.Controls.Add(this.log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(185, 178);
            this.Name = "Minecraft_Server_Actuator";
            this.Text = "Minecraft Server Actuator";
            this.context_trayicon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button server_on_button;
        private System.Windows.Forms.Button server_off_button;
        private System.Windows.Forms.Button server_reload_button;
        private System.Windows.Forms.Button server_datapack_reload_button;
        private System.Windows.Forms.Button server_kill_button;
        private System.Windows.Forms.Timer tick_1000;
        private System.Windows.Forms.Label server_on_time_text;
        private System.Windows.Forms.FolderBrowserDialog server_on_folder_path;
        private System.Windows.Forms.Timer color_change;
        private System.Windows.Forms.CheckBox darktheme_checkbox;
        private System.Windows.Forms.NotifyIcon trayicon;
        private System.Windows.Forms.ContextMenuStrip context_trayicon;
        private System.Windows.Forms.ToolStripMenuItem 서버켜기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버끄기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버강제종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버리로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버데이터팩리로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GUIToggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Button GUIToggle_button;
    }
}

