using System;

namespace ConsoleApp1_oop_5_4_2023
{
    class Vehicle // base/parent class
    {
        public string type;
    }

    class Car : Vehicle // child class
    {
        public string brand;
    }

    public abstract class GeoPosition
    {
        public abstract double latitude { get; }
        public abstract double longitude { get; }

        public abstract void locate();
    }

    public class Coordinate : GeoPosition, IFormattable
    {
        public override double latitude => 10;
        public override double longitude => 20;

        public override void locate()
        {
            Console.WriteLine("located");
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return formatProvider.ToString();
        }
    }

    public class Dummy { }

    

    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Car A = new Car();
            A.brand = "Myvi";
            A.type = "Compact";

            Vehicle B = A; // upcasting

            Console.WriteLine(B.type); // Compact

            Car C = (Car)B; // downcasting
            Console.WriteLine(C.brand); // Myvi
            Console.WriteLine(C.type); // Compact

            // abstract classes
            Coordinate coor = new Coordinate();
            Console.WriteLine(coor.latitude); // 10
            Console.WriteLine(coor.ToString());

            // object
            Dummy d = new Dummy();
            Console.WriteLine(d.GetHashCode()); // 58225482

            // boxing
            object c = coor;

            // unboxing
            Coordinate cc = (Coordinate)c;
            Console.WriteLine(cc.longitude); // 20

            int x = 12;
            int y = 100;
            Console.WriteLine($"{x}, {y}"); // 12, 100
            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}"); // 100, 12




        }
    }
}
