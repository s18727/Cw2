using System;
using System.IO;
using System.Xml.Serialization;

namespace Cw2
{

	public class Student
	{
		[XmlAttribute(attributeName: "index")]
		public string index {get; set;}
		[XmlElement(elementName: "fname")]
		public string fname { get; set; }
		[XmlElement(elementName: "lname")]
		public string lname { get; set; }
		[XmlElement(elementName: "birthDate")]
		public string bdate;
		[XmlElement(elementName: "email")]
		public string email { get; set; }
		[XmlElement(elementName: "mothersName")]
		public string mother { get; set; }
		[XmlElement(elementName: "fathersName")]
		public string father { get; set; }
		[XmlElement(elementName: "studies")]
		public Studies studies;

		public Student()
		{
			index = "";
			fname = "";
			lname = "";
			bdate = "";
			email = "";
			mother = "";
			father = "";
			studies = new Studies("","");

		}

		public Student(string[] values)
		{
			if (values.Length == 9)
			{
				fname = values[0];
				lname = values[1];
				studies = new Studies(values[2], values[3]);
				index = "s"+values[4];
				bdate = values[5];
				email = values[6];
				mother = values[7];
				father = values[8];
			}
			else
			{
				string msg = "Wrong values: ";
				foreach (string s in values)
				{
					msg = msg + s + " ";
				}

				Program.writeLog(msg);
			}
		}

		public string toString()
		{
			return $"{index} , {fname} , {bdate} , {email} , {studies}";
		}
	}
}
