using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {


            #region P26のサンプルプログラム
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daihukumoti = new Product(123, "大福もち", 180);
            //Console.WriteLine("かりんとうの税込み価格："+karinto.GetPriceIncludingTax());
            //Console.WriteLine("大福もちの税込み価格："+daihukumoti.GetPriceIncludingTax());
            #endregion

            #region 演習１
            //DateTime date =new DateTime(2023,5,8);
            DateTime date = DateTime.Today;

            TimeSpan ts1 = new TimeSpan(10, 0, 0, 0);


            //10日後を決める
            DateTime daysAfter = date + ts1;
            Console.WriteLine("10日後は" + daysAfter.Day );

            //10日前を決める
            DateTime daysAgo10 = date - ts1;
            Console.WriteLine("10日前は" + daysAgo10.Day );
            #endregion

            Console.WriteLine("西暦：");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("月：");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("日：");
            int birthDay = int.Parse(Console.ReadLine());


            DateTime birth = new DateTime(birthYear, birthMonth, birthDay,0,0,0);
            DateTime today = DateTime.Today;
            TimeSpan timeSpan = today - birth;
            Console.WriteLine("あなたは生まれてから今日まで{0}日です。", timeSpan.Days);

        }
    }
}
