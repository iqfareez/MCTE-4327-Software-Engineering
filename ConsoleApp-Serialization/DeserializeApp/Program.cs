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
            Console.WriteLine("Select formatter (x = XML, b = Binary): " );
            var chosenFormatter = Console.ReadLine();

            switch (chosenFormatter?.ToLower())
            {
                case "x":
                    // Deserialize from XML
                    var xml = new System.Xml.Serialization.XmlSerializer(typeof(Student));
                    var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var file = Path.Combine(desktop, "student.xml");
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
                    var desktop1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var file1 = Path.Combine(desktop1, "student.data");
                    FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
                    var maple2 = (Student) bf.Deserialize(fs1);
                    
                    Console.WriteLine("Done serializing to Binary");
                    Console.WriteLine(maple2.Name);
                    break;
                default:
                    Console.WriteLine("Invalid formatter");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}