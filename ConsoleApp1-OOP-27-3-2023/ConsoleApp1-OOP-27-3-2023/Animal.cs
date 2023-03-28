namespace ConsoleApp1_OOP_27_3_2023
{
    class Animal
    {
        // members/properties
        private int numberOfLegs;
        private bool canFly;

        // constructor
        public Animal(int legs, bool canFly)
        {
            this.numberOfLegs = legs;
            this.canFly = canFly;
        }

        // methods
        public void Speak() => System.Console.WriteLine("Purr");

        public void Fly() => System.Console.WriteLine(canFly ? "Wuhooo": "I can't fly");

    }
}
