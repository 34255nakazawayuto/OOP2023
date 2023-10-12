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
            var books = Library.Books.Max(b => b.Price);
            var book = Library.Books.Where(b=> books == b.Price);
            foreach (var f in book){
                Console.WriteLine(f);
            }
        }

        private static void Exercise1_3() {
            var count = Library.Books
                               .GroupBy(b => b.PublishedYear)
                               .Select(g =>(g.Key,g.Count()));
            foreach (var book in count){
                Console.WriteLine($"{book.Key}年    {book.Item2 }冊" );
            }
        }
        
        private static void Exercise1_4() {
            var groups = Library.Books
                                .Join(Library.Categories,
                                book => book.CategoryId,
                                Category => Category.Id,
                                (book, Category) => new {
                                    book.PublishedYear,
                                    book.Price,
                                    book.Title,
                                    CategoryName = Category.Name,
                                })
                                .OrderByDescending(x => x.PublishedYear)
                                .ThenByDescending(x => x.Price);

            foreach (var item in groups){
                Console.WriteLine("{0}年{1}円{2}({3})",
                                    item.PublishedYear,
                                    item.Price,
                                    item.Title,
                                    item.CategoryName
                                  );
            }
            //var groups = Library.Books
            //                 .GroupBy(b => b.PublishedYear)
            //                 .OrderBy(g => g.Key)
            //                 .OrderByDescending(k =>k);
            //foreach (var g in groups){
            //    Console.WriteLine($"{g.Key}年");
            //    foreach (var book in g){
            //        Console.WriteLine($"  {book}");
            //    }
           // }
            


        }

        private static void Exercise1_5() {
            var lookup = Library.Books
                                .Where(b=>b.PublishedYear==2016)
                                .Join(Library.Categories,
                                book => book.CategoryId,
                                Category => Category.Id,
                                (book, Category) => Category.Name)
                                .Distinct();
                             
            foreach (var book in lookup)
                Console.WriteLine(book);
        }

        private static void Exercise1_6() {



        }

        private static void Exercise1_7() {



        }

        private static void Exercise1_8() {



        }
    }
}
