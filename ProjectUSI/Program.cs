﻿using System;
using System.Windows.Forms;
using ProjectUSI.Data;
using ProjectUSI.Users.View;

namespace ProjectUSI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow());
        }
    }
}