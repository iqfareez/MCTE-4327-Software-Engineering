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
            var desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var maple = new Student() { Kulliyyah = "KOE", Name = "Fareez" };

            Console.WriteLine("Select formatter (x = XML, b = Binary, j = JSON): " );
            var chosenFormatter = Console.ReadLine();

            switch (chosenFormatter?.ToLower())
            {
                case "x":
                    // Serialize to XML
                    var xml = new System.Xml.Serialization.XmlSerializer(typeof(Student));
                    var file = Path.Combine(desktopDir, "student.xml");
                    FileStream fs = new FileStream(file, FileMode.Create);
                    xml.Serialize(fs, maple);
                    fs.Close();

                    Console.WriteLine("Done serializing to XML. File saved to " + file);

                    break;
                case "b":
                    // Serialize to Binary
                    BinaryFormatter bf = new BinaryFormatter();
                    var file1 = Path.Combine(desktopDir, "student.data");
                    FileStream fs1 = new FileStream(file1, FileMode.Create);
                    bf.Serialize(fs1, maple);
                    fs1.Close();
                    
                    Console.WriteLine("Done serializing to Binary. File saved to " + file1);
                    break;
                case "j":
                    // Serialize to JSON
                    var file2 = Path.Combine(desktopDir, "student.json");
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(maple);
                    File.WriteAllText(file2, json);
                    
                    Console.WriteLine("Done serializing to JSON. File saved to " + file2);
                    break;
                default:
                    Console.WriteLine("Invalid formatter");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}