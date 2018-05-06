using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApplication1
{
    [Serializable, XmlInclude(typeof(DataBaseForStudents))]
    public class DataBaseForStudents
    {
        public DataBaseForStudents() { }
        public DataBaseForStudents(string fio, string age, string fak, string direction, int course, string expirience)
        {
            this.fio = fio;
            this.age = age;
            this.fak = fak;
            this.direction = direction;
            this.course = course;
            this.expirience = expirience;
        }
        public string fio { get; set; }
        public string age { get; set; }
        public string fak { get; set; }
        public string direction { get; set; }
        public int course { get; set; }
        public string expirience { get; set; }
    }
}
