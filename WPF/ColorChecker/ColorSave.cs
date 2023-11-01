using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorChecker {
    class ColorSave {
        public override string ToString() {
            return " R: "+Color.R+" G: "+Color.G+" B: "+Color.B;
        }
        public Color Color { get; set; }
    }
}
