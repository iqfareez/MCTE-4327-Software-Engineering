using System;

namespace ConsoleApplication1_Birthday_Exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var birthday = new Birthday();
            Console.WriteLine("Enter your birthday dd/mm/yyyy" );
            string input = Console.ReadLine();

            Console.WriteLine(input);
            birthday.TodayIsBirthday += () => Console.WriteLine("Happy Birthday!");
            birthday.ImpossibleAgeEntered += (sender, eventArgs) => Console.WriteLine("Impossible age entered");
            birthday.ImproperDateEntered += (sender, eventArgs) => Console.WriteLine("Improper date entered");
            birthday.ImproperInputEntered += (sender, eventArgs) => Console.WriteLine("Improper input entered");
            birthday.EverythingIsOkay += (age, dayOfWeek) => Console.WriteLine($"Your age is {age} and your birthday is on {dayOfWeek}");
            birthday.Start(input);
        }
    }
}