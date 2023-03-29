using System;

namespace ConsoleApp2_OOP_29_3_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 6);

            //v1.x = 10; // error

            Console.WriteLine(v1.x);
            Console.WriteLine(v1.Sum);
        }
    }
}
