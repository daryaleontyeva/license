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
        public DataBaseForStudents(string fio, string age, string fak, string game, int skill, int course, string twitch, string expirience)
        {
            this.fio = fio;
            this.age = age;
            this.fak = fak;
            this.game = game;
            this.skill = skill;
            this.course = course;
            this.twitch = twitch;
            this.expirience = expirience;
        }
        public string fio { get; set; }
        public string age { get; set; }
        public string fak { get; set; }
        public string game { get; set; }
        public int skill { get; set; }
        public int course { get; set; }
        public string twitch { get; set; }
        public string expirience { get; set; }
    }
}
