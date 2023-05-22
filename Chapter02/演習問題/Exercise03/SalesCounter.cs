using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class SalesCounter {
        private IEnumerable<Sale> _sales;
            //コンストラクタ
            public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
            }

        private static IEnumerable<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
                foreach (var line in lines) {
                    var items = line.Split(',');
                    var sale = new Sale {
                        ShopName = items[0],
                        ProductCategory = items[1],
                        Amount = int.Parse(items[2])
                    };
                    sales.Add(sale);
                }
                return sales;
            }
            //店舗別売り上げを求める
            public Dictionary<string, int> GetPerStoreSales() {
                var dict = new Dictionary<string, int>();
                foreach (var sale in _sales) {
                    if (dict.ContainsKey(sale.ProductCategory))
                        dict[sale.ProductCategory] += sale.Amount; //店名がすでに存在する（売り上げ加算）
                    else
                        dict[sale.ProductCategory] = sale.Amount;  //店名が存在しない（新規格納）
                }
                return dict;
            }
        }
    }
