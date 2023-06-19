using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };

            Console.WriteLine(numbers.Average());

            var books =Books.GetBooks();

            //◎500円以上の本のタイトルを全て出力

            // var booksObj = books.Where(x => x.Title.Contains ("物語"))
            //                      .OrderByDescending(x=>x.Price);

            //◎タイトルに＜物語＞という文字列が含まれている書籍の平均ページ数を出力

            var booksObj = books.Where(x => x.Title.Contains("物語"))
                                    .Average(x => x.Pages);           

                Console.WriteLine("平均：{0}円",booksObj);
            //◎価格が大きい順に並べタイトルが長い順に並び変える
            var longTitleBooks = books.OrderByDescending(x => x.Title.Length);
            foreach (var book in longTitleBooks){
                Console.WriteLine("{0} {1}", book.Title, book.Price);

            }
         }
    }
}

