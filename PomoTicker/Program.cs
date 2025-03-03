﻿using System;
using System.Windows.Forms;

namespace PomoTicker
{
    static class Program
    {
        /// <summary>
        ///  Main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimerForm());
        }
    }
}
