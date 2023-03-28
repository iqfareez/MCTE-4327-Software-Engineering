using System;
using System.Threading;

namespace ClassExercise_27_3_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new(brand: "Ferrari", color: "Red");
            Car porshe = new(brand: "Porshe", color: "Black");
            Car king = new(brand: "Myvi", color: "Yellow");

            // drive all cars
            ferrari.StartDrive();
            porshe.StartDrive();
            king.StartDrive();

            Thread.Sleep(2000); // pause for 2 secs
            Console.WriteLine();

            // stop all cars
            ferrari.StopDrive();
            porshe.StopDrive();
            king.StopDrive();
        }
    }
}
