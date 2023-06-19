﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);

        }

       

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            int[] lastN = numbers.Skip(numbers.Length - 2).ToArray();
           
            foreach (int n in lastN){
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var str = numbers .Select(n =>n.ToString());
            foreach (var s in str){
                Console.WriteLine(str);
            }
        }
        private static void Exercise1_4(int[] numbers) {
            foreach (var n in numbers.OrderBy(n => n).Take(3))
                Console.WriteLine(n);
        }

        private static void Exercise1_5(int[] numbers) {
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(count);
        }
    }
}
