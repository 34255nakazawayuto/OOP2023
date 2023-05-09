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


            //DateTime date =new DateTime(2023,5,8);
            DateTime date = DateTime.Today;

            TimeSpan ts1 = new TimeSpan(10, 0, 0, 0);


            //10日後を決める
            DateTime daysAfter = date + ts1;
            Console.WriteLine("10日後は" + daysAfter.Day );

            //10日前を決める
            DateTime daysAgo = date - ts1;
            Console.WriteLine("10日前は" + daysAgo.Day );


        }
    }
}
