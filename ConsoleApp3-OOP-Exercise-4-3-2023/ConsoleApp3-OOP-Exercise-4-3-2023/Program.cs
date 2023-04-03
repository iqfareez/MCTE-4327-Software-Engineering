using System;

namespace ConsoleApp3_OOP_Exercise_4_3_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            Pet cat = new Pet(
                name: "Makcik", size: Size.chonk,  mass: 3, sound: "meowr"
                );

            Console.WriteLine(cat); // Cat Makcik, chonk, 3, meowr

            cat.SayMyName(); // Makcik

            // Polymorphism
            WarmBlood alien = new Pet(name: "Zuzuu", size: Size.small, mass: 100, sound: "arghh");
            alien.SayMyName(); // Zuzuu

        }
    }
}
