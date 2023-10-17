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
                               .GroupBy(x => x.CategoryName)
                               .OrderBy(x => x.Key);

            foreach (var group in groups){
                Console.WriteLine("#{0}",group.Key);
                foreach (var book in groups){
                    Console.WriteLine("{0}",book);
                }
            }
        }

        private static void Exercise1_7() {
            var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books.Where(b => b.CategoryId == catid)
                                      .GroupBy(b => b.PublishedYear)
                                      .OrderBy(b => b.Key);
            foreach (var group in groups){
                Console.WriteLine("#{0}年",group.Key);

                foreach (var book in group){
                    Console.WriteLine("{0}",book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                               .GroupJoin(Library.Books, c => c.Id, 
                                                         b => b.CategoryId, 
                                                         (c, b) => new { CategoryaName = c.Name
                                                         ,Count = b.Count() }).Where(x => x.Count >= 4);
            foreach (var category in query){
                Console.WriteLine(category.CategoryaName);
            }

        }
    }
}
