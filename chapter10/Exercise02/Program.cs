﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {
            foreach (var line in File.ReadLines(file)){         
                var matches = Regex.Matches(line, @"\b[0-9]{3,}\b");
                foreach (Match item in matches){
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
