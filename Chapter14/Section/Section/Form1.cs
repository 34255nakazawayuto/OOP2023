﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void btRunNotepad_Click(object sender, EventArgs e) {
            var path = @"%SystemRoot%system32\notepad.exe";
            var fullpath = Environment.ExpandEnvironmentVariables(path);

            var startInfo = new ProcessStartInfo
            {
                FileName = fullpath,
                Arguments = @"C:\temp\Sample.txt",
                WindowStyle = ProccesWindowStyle.Maximized
            };
            Procces.Stsrt(startInfo);
        }
        private void btRunWaitNotepad_Click(object sender, EventArgs e) {

        }

        
    }
}
