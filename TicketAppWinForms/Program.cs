﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.View;

namespace TicketAppWinForms
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
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            Application.Run();
        }
    }
}


/*var main_form = new Form1();
main_form.Show();
Application.Run();
*/