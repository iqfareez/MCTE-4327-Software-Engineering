using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeserializeApp
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
            Console.WriteLine("Select formatter (x = XML, b = Binary, j = JSON): " );
            var chosenFormatter = Console.ReadLine();

            switch (chosenFormatter?.ToLower())
            {
                case "x":
                    // Deserialize from XML
                    var xml = new System.Xml.Serialization.XmlSerializer(typeof(Student));
                    var file = Path.Combine(desktopDir, "student.xml");
                    FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                    var maple = (Student) xml.Deserialize(fs);
                    fs.Close();
                    
                    Console.WriteLine("Done deserializing from XML");
                    Console.WriteLine(maple.Name);

                    break;
                case "b":
                    // Serialize to Binary
                    // Currently, this method wont works, maybe because im using different namespace
                    BinaryFormatter bf = new BinaryFormatter();
                    var file1 = Path.Combine(desktopDir, "student.data");
                    FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
                    var maple2 = (Student) bf.Deserialize(fs1);
                    
                    Console.WriteLine("Done serializing to Binary");
                    Console.WriteLine(maple2.Name);
                    break;
                case "j":
                    // Deserialize from JSON
                    var file2 = Path.Combine(desktopDir, "student.json");
                    var json = File.ReadAllText(file2);
                    var maple3 = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(json);
                    
                    Console.WriteLine("Done deserializing from JSON");
                    Console.WriteLine(maple3.Name);
                    break;
                default:
                    Console.WriteLine("Invalid formatter");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}