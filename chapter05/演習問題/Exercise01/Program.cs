using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            //5,1       
            Console.WriteLine("文字列１：");
            var s1 = Console.ReadLine();

            Console.WriteLine("文字列２：");
            var s2 = Console.ReadLine();

            if (s1 == s2){
                Console.WriteLine("一致しています");
            }else{
                Console.WriteLine("一致していない");
            }

           

        }
    }
}
