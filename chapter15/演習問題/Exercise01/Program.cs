using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(b => b.Price);
            Console.WriteLine(price);
        }

        private static void Exercise1_3() {
            var count = Library.Books
                               .GroupBy(b => b.PublishedYear);
            foreach (var book in count){
                
                Console.WriteLine($"{count.Count(n => n >= 3 && n <= 8)}");
            }
        }

        private static void Exercise1_4() {



        }

        private static void Exercise1_5() {



        }

        private static void Exercise1_6() {



        }

        private static void Exercise1_7() {



        }

        private static void Exercise1_8() {



        }
    }
}
