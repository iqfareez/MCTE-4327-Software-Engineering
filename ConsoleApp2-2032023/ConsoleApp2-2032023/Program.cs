using System;

namespace ConsoleApp2_2032023
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHello();
            PrintWelcome("Fareez");
            Console.WriteLine(AddNumber(1,5));

            // unpack tuple
            (string catName, int catAge) = LookupCat();
            Console.WriteLine(catName);
            Console.WriteLine(catAge);
        }

        // why static? To allow one object shaja exist?
        private static void PrintHello()
        {
            Console.WriteLine("Hello world");            
        }

        private static void PrintWelcome(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        private static int AddNumber(int a, int b)
        {
            return a + b;
        }

        // tuple like
        static (string, int) LookupCat()
        {
            return ("Cicik", 12);
        }
    }
}
