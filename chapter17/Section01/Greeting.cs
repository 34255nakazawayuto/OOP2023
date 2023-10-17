using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class GreetingMorning :IGreeting{//継承
        public  string GetMessage() {
            return "おはよう";
        }
    }
    class GreetingAfternoon :IGreeting{//継承
        public  string GetMessage() {
            return "こんにちは";
        }
    }
    class GreetingEvening :IGreeting{//継承
        public  string GetMessage() {
            return "こんばんは";
        }
    }
}
