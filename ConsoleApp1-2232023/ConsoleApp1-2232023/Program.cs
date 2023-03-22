using System;

namespace ConsoleApp1_2232023
{
    class Point
    {
        public int x;
        public int y;
    }

    class Program
    {    

        static void Main(string[] args)
        {
            int x = 0;
            IncrementNumber(x); // 10
            Console.WriteLine(x); // 0

            ForceIncrementNumber(ref x);
            Console.WriteLine(x); // 10

            // function w/ default parameter
            DisplayMessage(); // bar
            DisplayMessage("jaja"); // jaja

            Point p = new Point();
            p.x = 12;
            p.y = 10;
            Console.WriteLine(p.x); // 12
            ProcessPoint(p);
            Console.WriteLine(p.x); // 100

            // String
            var boo = "my message here";
            Console.WriteLine(boo.Length); // 15
            Console.WriteLine(boo.Substring(4, 8)); // essage h

            // Splitting string. By default, the delimiter is " "
            var s = boo.Split(); // ["my", "message", "here"]

            int z = 80;
            DisplayMessage(z.ToString()); // 80

            // DateTime
            var myDate = DateTime.Now;
            Console.WriteLine(myDate); // 3/22/2023 10:45:44 AM

            // DateTime formatting
            // display time and day of the week
            Console.WriteLine(myDate.ToString("HH:mm, dddd")); // 10:49, Wednesday

            // Parsing
            var id = "378241";
            var idNum = int.Parse(id); // idNum is same with id, but as integer
        }

        // pass by value
        static void IncrementNumber(int num)
        {
            num+=10;
            Console.WriteLine(num);
        }

        // Force pass by reference
        static void ForceIncrementNumber(ref int num)
        {
            num+=10;
        }

        // with default parameter
        static void DisplayMessage(string text = "bar")
        {
            Console.WriteLine(text);
        }

        static void ProcessPoint(Point q)
        {
            q.x = 100;
        }
    }
}
