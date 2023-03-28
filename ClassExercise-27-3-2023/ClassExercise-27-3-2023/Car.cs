using System;

namespace ClassExercise_27_3_2023
{
    class Car
    {
        // members/properties
        private string color;
        private string brand;

        // constructor
        public Car(string brand, string color)
        {
            this.brand = brand;
            this.color = color;
        }

        // methods/functions
        public void StartDrive() => Console.WriteLine($"{brand} Started Driving");

        public void StopDrive() => Console.WriteLine($"{brand} Stopped Driving");


    }
}
