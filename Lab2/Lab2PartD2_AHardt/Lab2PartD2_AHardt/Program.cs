﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2PartD2_AHardt
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
