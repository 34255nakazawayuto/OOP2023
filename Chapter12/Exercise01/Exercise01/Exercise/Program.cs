using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {


            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        public static void Exercise1_1(string v) {
            var employee = new Employee{
                Id = 9999,
                Name = "川村北郎",
                HireDate = new DateTime(2023, 2, 3),
            };

            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
                //シリアル化
                using (var writer = XmlWriter.Create(v)){
                    var serializer = new XmlSerializer(employee.GetType());
                    serializer.Serialize(writer, employee);
                }
                //逆シリアル化
                using (var reader = XmlReader.Create(v)){
                    var serializer = new XmlSerializer(typeof(Employee));
                    var w = serializer.Deserialize(reader) as Employee;
                    Console.WriteLine(w);
                }
        }
                


        private static void Exercise1_2(string v) {
            var employee = new Employee[]{
                new Employee{
                Id = 9999,
                Name = "川村北郎",
                HireDate = new DateTime(2023, 2, 3),
                }
            };
            var settings = new XmlWriterSettings{
                    Encoding = new System.Text.UTF8Encoding(false),
                    Indent = true,
                    IndentChars = " ",
                };
                using (var writer = XmlWriter.Create(v)){
                    var serializer = new DataContractSerializer(employee.GetType());
                    serializer.WriteObject(writer, employee);
                }
        }

        private static void Exercise1_3(string v){
            
            using (var reader = XmlReader.Create(v)){
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var employee01 = serializer.ReadObject(reader) as Employee[];
            }
        }
        private static void Exercise1_4(string v) {
            var employee = new Employee[]{
                new Employee{
                Id = 9999,
                Name = "川村北郎",
                HireDate = new DateTime(2023, 2, 3),
                }
            };
            //逆シリアル化
            /*using(var stream = new MemoryStream()){
                var serializer = new DataContractJsonSerializer(v.GetType());
                serializer.WriteObject(stream, v);
                stream.Close();
                var jsonText = Encoding.UTF8.GetString(stream.ToArray());
                Console.WriteLine(jsonText);
            }*/
            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write)){
                var serializer = new DataContractJsonSerializer(employee.GetType());
                serializer.WriteObject(stream, employee);
            }
        }
    }
}
