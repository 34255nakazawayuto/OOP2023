using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //イベントハンドラ
        private void btPow_Click(object sender, EventArgs e) {

           double result= Math.Pow((double)nudX.Value, (double)nudY.Value);
            tbResult.Text = result.ToString();
            //一行で書く場合
             //tbResult.Text = (Math.Pow((double)nudX.Value, (double)nudY.Value)).ToString();
        }
    }
}
