using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test03 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        
        //メソッドの概要： 点数データを読み込み、Scoreオブジェクトのリストを返す 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                var items = line.Split(',');
                var student = new Student
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                };
                students.Add(student);
                
            }
            return students;
        }

        //メソッドの概要： 個人別合計点数を求めて平均点を表示
        public IDictionary<string, int> GetPerStudentScore() {
           
            var dict = new SortedDictionary<string, int>();
            foreach (Student student in _score)
            {
                if (dict.ContainsKey(student.Name))
                    dict[student.Name] += student.Score;//名前ごとの点数を足していく
                else
                    dict[student.Name] = student.Score;
            }
            
            return dict;
            
        }
        
    }
}
