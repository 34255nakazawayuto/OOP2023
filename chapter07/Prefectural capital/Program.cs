using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefectural_capital {
    class Program {
        static void Main(string[] args) {
            var prefOfficeDict = new Dictionary<string, string>();
            string pref;
            string city;

            Console.WriteLine("県庁所在地の登録");
            Console.WriteLine("県名を入力：");
            while (true)
            {
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.WriteLine("所在地");
                city = Console.ReadLine();

                //すでに県が登録済みか
                if (prefOfficeDict.ContainsKey(pref)){
                    Console.WriteLine("すでに県名が登録されています");
                    Console.Write("上書きしますか(y,n)");
                    if(Console.ReadLine() == "y"){
                        prefOfficeDict[pref] = city;
                    }
                }
                else{
                    prefOfficeDict[pref] = city;
                }
                Console.Write("県名：");
            }

           


            //県名指定出力処理
            Console.WriteLine("県名を入力：");
            var inputPref = Console.ReadLine();
            Console.WriteLine("{0}です", prefOfficeDict[inputPref]);
        }
    }
}
