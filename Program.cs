    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    namespace Cw2
    {

        public class Program
        {
        static string log;
        public static void Main(string[] args)
        {
            log = "";
            string pathin, pathout, pathlog = @"log.txt";
            if (args.Length <= 1)
            {
                pathin = @"data.csv";
                pathout = @"result.xml";
            }
            else
            {
                pathin = args[0];
                pathout = args[1];

            }

            try { var students = In(pathin);
                string date = DateTime.Today.ToShortDateString(), rattr = $"uczelnia\ncreated at: {date}\nauthor:Rafał Jaglak";
                Uczelnia uczelnia = new Uczelnia(date, "Rafał Jaglak", students);
                FileStream writer = new FileStream(pathout, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(Uczelnia));
                serializer.Serialize(writer, uczelnia);
            }
            catch(ArgumentException e) { 
                writeLog("Zła ścieżka");
            }
            catch (FileNotFoundException e){
                writeLog("Brak pasujących wyników");
            }

            System.IO.File.WriteAllText(
                pathlog, 
                log
             );
        }

            public static List<Student> In(string path) {
                try
                {
                    var lines = File.ReadLines(path);
                    HashSet<Student> students = new HashSet<Student>(new OwnComparer());
                foreach (string s in lines)
                {
                    students.Add(
                        new Student(
                            s.Split(
                                ","
                                )
                            )
                        );
                    }
                    foreach (Student s in students)
                {
                    Console.WriteLine(s.toString());
                }
                    return new List<Student>(students);
                } catch (Exception e)
                    {
                        Console.WriteLine(e);
                   }
            return new List<Student>();
            }

            public static void writeLog(string msg)
            {
                log += msg + "\n";
            }

        }
    }
