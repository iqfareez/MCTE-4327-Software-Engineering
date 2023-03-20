using System;

namespace ConsoleApp1_2032023
{
    /// <summary>
    ///  Value type
    /// </summary>
    struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{x},{y}";
        }
    }
    
    /// <summary>
    /// Reference type
    /// </summary>
    class Coordinate
    {
        public double latitude;
        public double longitude;

        public Coordinate(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public override string ToString()
        {
            return $"{latitude},{longitude}";
        }
    }

    /// <summary>
    /// To test default value
    /// </summary>
    class Meow
    {
        public int a;
        public int b;

        public override string ToString()
        {
            return $"{a} and {b}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // the type will be determined at compile time
            var s = "teststring";
            // add breakpoint after the line above to see the inferred type

            // 1-D array
            var listOfNum = new int[] { 1, 3, 5, 7, 9 };

            // for vs foreach
            for (var i = 0; i < listOfNum.Length; i++)
            {
                listOfNum[i] = listOfNum[i] + 2;
            }

            Console.WriteLine(listOfNum.ToString());

            foreach (var i in listOfNum)
            {
                Console.WriteLine(i);
            }

            // Takeaways: [for] allow us to modify the value in an array
            // meanwhile using [foreach], since the value is declared to [i], the value
            // of the array element can't be changed
            */

            // Value type vs reference type

            var pos1 = new Coordinate(101.2, 3.14);
            var pos2 = pos1;

            // by doing the change below to pos1, the pos2 value is also changed
            pos1.latitude = 300.2;

            // the printed value is same
            // the behavior below can be overcome by using struct (value type)
            // instead of class
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);

            var posi1 = new Position(1, 2);
            var posi2 = posi1;

            // by doing the change below to posi1, only posi1 is changed
            posi1.x = 4;

            // they printed differently
            Console.WriteLine(posi1);
            Console.WriteLine(posi2);

            // default value ???
            int a;
            char b;
            double c;
            //  Use of unassigned local variable 'a'
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // ohh, default value worked with classes only
            var meow = new Meow();
            Console.WriteLine(meow); //printed "0 and 0" (default value)

            // anonymous type
            var kuceng = new { Name = "comot", Age = 4 };
            Console.WriteLine(kuceng.Name); // comot
        }
    }
}
