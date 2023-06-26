using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            var prefDict = new Dictionary<string, List<CityInfo>>();
            string pref, city;
            int population;

            Console.WriteLine("都市の登録");
            while (true)
            {
                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("市町村：");
                city = Console.ReadLine();

                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());

                //市町村情報インスタンスの生成
                var cityInfo = new CityInfo
                {
                    City = city,
                    Population = population,
                };

                //既に県名が未登録
                if (!prefDict.ContainsKey(pref))
                {
                    prefDict[pref] = new List<CityInfo>();
                }
                prefDict[pref].Add(cityInfo);
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if ("1"==selected) {
                foreach (var  dict in  prefDict){
                    foreach (var cityInfo in dict.Value){
                        Console.WriteLine("{0}【{1}(人口:{2}人】)",dict.Key,cityInfo.City,cityInfo.Population);
                    }
                }
            }
                //if (prefDict.ContainsKey(selected))
                //{
                //    Console.WriteLine(selected);
                //    foreach (var item in prefDict[selected])
                //    {
                //        Console.WriteLine(selected, item.City, item.Population);
                //    }
                //}
                else
                {
                    //県名指定表示
                    Console.Write("県名を入力：");
                    var inputPref = Console.ReadLine();
                    foreach (var item in prefDict[inputPref]){
                        Console.WriteLine("【{0}(人口：{1}人)】", prefDict[inputPref], item.Population);
                    }
                }
            }
        }
    }

class CityInfo {
    public string City { get; set; }        //都市
    public int Population { get; set; }     //人口
}


