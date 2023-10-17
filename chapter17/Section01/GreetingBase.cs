using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    abstract class GreetingBase {//抽象クラスのためabstractをつける
        public  virtual string GetMessage() {
            return " ";
        }
    }
}
