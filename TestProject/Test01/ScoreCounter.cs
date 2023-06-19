using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            public ScoreCounter(string filePath) {
                _score = Readscore(filePath);
            }
            private static IEnumerable<Student> ReadSales(string filePath) {
                var sales = new List<Student>();
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var items = line.Split(',');
                    var score = new Student
                    {
                        Name = items[0],
                        Subject = items[1],
                        Score = int.Parse(items[2])
                    };
                    score.Add(score);
                }
                return score;
            }


        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> score = new List<Student>();







        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {





            
        }
    }
}
