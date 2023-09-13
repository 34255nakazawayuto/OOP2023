using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01 {
    class Program {
        static void Main(string[] args) {

            var dateTime = new DateTime(2023, 6, 30, 11, 37, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
           // DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15/ 19:48
            var s = dateTime.ToString("f");
            Console.WriteLine(s);

        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019/01月　15日　19時48分32秒
            var s1 = dateTime.ToString("yyyy年/MM月dd日 HH時mm分ss秒");
            Console.WriteLine(s1);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年　1月15日(火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = dateTime.ToString("ggyy年M月d日(ddd曜日)", culture);
            Console.WriteLine(str);


            // private static void DisplayDatePattern3_2(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var s4 = dateTime.ToString("ggyy年M月d日(dddd)", culture);
            
            var str Regex.Replace(datestr, @"0(\d)", "$1");
           // }
        }
    }
}
