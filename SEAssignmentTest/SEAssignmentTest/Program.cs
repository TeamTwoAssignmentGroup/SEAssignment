﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEAssignmentTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. hello world
        /// Nigel was 'ere
        /// 
        /// Demonstration of push pull etc
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
