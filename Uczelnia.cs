using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cw2
{
    public class Uczelnia
    {
        [XmlAttribute(attributeName: "createdAt")]
        public string date { get; set; }
        [XmlAttribute(attributeName: "author")]
        public string author { get; set; }
        public List<Student> students { get; set; }

        public Uczelnia(string dat,string aut,List<Student> stud)
        {
            date = dat;
            author = aut;
            students = stud;
        }

        public Uczelnia()
        {
            date = "";
            author = "";
            students = new List<Student>();
        }
    }
}
