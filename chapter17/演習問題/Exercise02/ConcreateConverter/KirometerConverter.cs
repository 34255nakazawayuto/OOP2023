using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.ConcreateConverter {
    class KirometerConverter :Framework.ConverterBase{

        protected override double Ratio { get { return 1; } }
        public override string UnitName { get { return "キロメートル"; } }

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "kirometer" || name == UnitName;
        }










    }
}
