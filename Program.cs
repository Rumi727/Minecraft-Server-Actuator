using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_Actuator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "/asp" && args.Length > i + 1)
                    Minecraft_Server_Actuator.config.AutoStartPath = args[i + 1];
                else if (args[i] == "/r" && args.Length > i + 1)
                {
                    if (int.TryParse(args[i + 1], out int temp))
                        Minecraft_Server_Actuator.config.Ram = temp;
                }
                else if (args[i] == "/sn" && args.Length > i + 1)
                    Minecraft_Server_Actuator.config.ServerName = args[i + 1];
                else if (args[i] == "/src" && args.Length > i + 1)
                    Minecraft_Server_Actuator.config.ServerReloadCommand = args[i + 1];
                else if (args[i] == "/sdrc" && args.Length > i + 1)
                    Minecraft_Server_Actuator.config.ServerDatapackReloadCommand = args[i + 1];
                else if (args[i] == "/ssc" && args.Length > i + 1)
                    Minecraft_Server_Actuator.config.ServerStopCommand = args[i + 1];
                else if (args[i] == "/stc" && args.Length > i + 1)
                    Minecraft_Server_Actuator.config.TaskkillCommand = args[i + 1];
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Minecraft_Server_Actuator());
        }
    }
}
