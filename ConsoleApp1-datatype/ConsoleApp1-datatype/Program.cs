using System;

namespace ConsoleApp1_datatype
{
    class Program
    {
        struct Student
        {
            public string name;
            public int age;

            public override string ToString()
            {
                return $"{name} - {age}";
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("hewwo world");
            //Console.ReadLine();   

            Student student1;
            student1.name = "Fareez";
            student1.age = 12;

            Console.WriteLine(student1);
        }
    }
}
