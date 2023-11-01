using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.ConcreateConverter {
    class FeetConverter :Framework. ConverterBase {

        protected override double Ratio { get { return 0.3048; } }
        public override string UnitName { get { return "フィート"; } }

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "feet" || name == UnitName;
        }
    }
}
