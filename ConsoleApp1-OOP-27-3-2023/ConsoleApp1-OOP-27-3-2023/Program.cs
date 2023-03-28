using System;

namespace ConsoleApp1_OOP_27_3_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiation (using constructor)
            Animal dragon = new Animal(legs: 4, canFly:true);

            dragon.Speak(); // Purr
            dragon.Fly(); // Wuhooo
        }
    }
}
