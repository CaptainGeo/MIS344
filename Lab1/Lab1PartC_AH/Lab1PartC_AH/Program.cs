﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab1PartC_AH
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
