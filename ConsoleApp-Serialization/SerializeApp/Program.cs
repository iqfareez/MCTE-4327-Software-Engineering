using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeApp
{
    [Serializable]
    public class Student
    {
        public string Name;
        public string Kulliyyah;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var maple = new Student() { Kulliyyah = "KOE", Name = "Fareez" };

            Console.WriteLine("Select formatter (x = XML, b = Binary: " );
            var chosenFormatter = Console.ReadLine();

            switch (chosenFormatter?.ToLower())
            {
                case "x":
                    // Serialize to XML
                    var xml = new System.Xml.Serialization.XmlSerializer(typeof(Student));
                    var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var file = Path.Combine(desktop, "student.xml");
                    FileStream fs = new FileStream(file, FileMode.Create);
                    xml.Serialize(fs, maple);
                    fs.Close();

                    Console.WriteLine("Done serializing to XML");

                    break;
                case "b":
                    // Serialize to Binary
                    BinaryFormatter bf = new BinaryFormatter();
                    var desktop1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var file1 = Path.Combine(desktop1, "student.data");
                    FileStream fs1 = new FileStream(file1, FileMode.Create);
                    bf.Serialize(fs1, maple);
                    fs1.Close();
                    
                    Console.WriteLine("Done serializing to Binary");
                    break;
                default:
                    Console.WriteLine("Invalid formatter");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}