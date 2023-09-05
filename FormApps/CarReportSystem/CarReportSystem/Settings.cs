using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    //設定情報
    public class Settings {
        private static Settings instans;

        public int MainFormColor { get; set; }

        //コンストラクタ
    private Settings() { }

    static public Settings getInstans() {
            if (instans == null){
                instans = new Settings();
            }
            return instans;
          
        }
    }
}
