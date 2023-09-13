using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender,EventArgs e) {
            var dtp = dtpDate.Value;
            var now = DateTime.Now;

            tbMessage.Text = "入力したら日にちから" + (now - dtp).Days + "日経過";
        }


        private void Form1_Load(object sender , EventArgs e) {
            var dtp = DateTime.Now;
        }

        //private void btForwardYear_Click(object sender, EventArgs e) {
        //}

        private void btAge_Click(object sender, EventArgs e) {
            var age = GetAge(dtpDate.Value, DateTime.Now);
                tbMessage.Text = "あなたの年齢は" + age + "歳です";

        public static int GetAge(DateTime birthday,DateTime targetDay) {     
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)){
                age--;
            }
            return age;
        }

    }
}

