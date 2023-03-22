using System;


namespace ConsoleApp2_2232023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception handling
            try
            {
                int num = 10;
                num = num / 0;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // Attempted to divide by zero.
            }

            Console.WriteLine("The program will still be continued until here");

            // Random number
            Random rand = new Random();

            int dice = rand.Next(1, 7);
            Console.WriteLine(dice);

            // File IO
            string path = @"../../../message.txt"; // message.txt is in the same level as Program.cs
            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine(text);
        }
    }
}
