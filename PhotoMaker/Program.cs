﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoMaker
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhotoMakerForm());

            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            //if (!wp.IsInRole(WindowsBuiltInRole.Administrator))
            //{
            //    var processInfo = new ProcessStartInfo();
            //    // The following properties run the new process as administrator
            //    processInfo.UseShellExecute = true;
            //    processInfo.FileName = Application.ExecutablePath;
            //    processInfo.Verb = "runas";

            //    // Start the new process
            //    try
            //    {
            //        Process.Start(processInfo);
            //    }
            //    catch (Exception ex)
            //    {
            //        // The user did not allow the application to run as administrator
            //        MessageBox.Show("Sorry, this application must be run as Administrator.\n" + ex.Message);
            //    }

            //}
            //else
            //{
            //    //Application.SetCompatibleTextRenderingDefault(false);
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new PhotoMakerForm());
            //}
        }
    }
}
