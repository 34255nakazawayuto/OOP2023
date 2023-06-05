using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            {
                //int count = 0;
                //foreach (char c in text){
                //  if (c == ' '){
                //    count++;
                // }
                //}
                //Console.WriteLine("空白数："+count);





            }
            int space = text.Count(f => f == ' ');
            Console.WriteLine("空白数：{0}", space);
        }

        private static void Exercise3_2(string text) {
            var target = text;
            var replaced = target.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            var str = text;
            var count = 0;
            string[] words = str.Split(' ');
            foreach (var item in words) {
                count++;
            }
            Console.WriteLine(count);
        }

        private static void Exercise3_4(string text) {
            
        }

        private static void Exercise3_5(string text) {
           
        }
    }
}
