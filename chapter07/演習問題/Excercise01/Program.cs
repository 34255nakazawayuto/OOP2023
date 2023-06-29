using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }
        #region
        private static void Exercise1_1(string text) {
            var nameDict = new Dictionary<Char, int>();
            foreach (var item in text)
            {
                var uc = char.ToUpper(item);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (nameDict.ContainsKey(uc))
                    {
                        nameDict[uc]++;
                    }
                    else
                    {
                        nameDict[uc] = 1;
                    }
                }
            }
            foreach (var item in nameDict.OrderBy(c => c.Key))
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
        #endregion
        private static void Exercise1_2(string text) {
                var dict = new SortedDictionary<Char, int>();
            var nameDict = new Dictionary<Char, int>();
            foreach (var item in text)
            {
                var uc = char.ToUpper(item);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (nameDict.ContainsKey(uc))
                    {
                        nameDict[uc]++;
                    }
                    else
                    {
                        nameDict[uc] = 1;
                    }
                }
            }
            
        }
    }
}

