﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
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
            
            //Bu kısmı sırf login ile girmemek için Dashboard yaptık
            //tekrardan Login ile degistir proje bitince
            Application.Run(new Login());
            //Application.Run(new Dashboard());
        }
    }
}
