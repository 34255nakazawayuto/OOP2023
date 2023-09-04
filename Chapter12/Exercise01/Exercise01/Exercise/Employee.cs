using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise01 {
    //[DataContract(Name ="employee")]
    [XmlRoot("employee")]
   public class Employee {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("hiredate")]
        public DateTime HireDate { get; set; }
        }
    }

