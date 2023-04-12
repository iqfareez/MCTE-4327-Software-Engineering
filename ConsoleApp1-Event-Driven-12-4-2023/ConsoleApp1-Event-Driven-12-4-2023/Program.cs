using System;

namespace ConsoleApp1_Event_Driven_12_4_2023
{
    public class Counter
    {
        public event EventHandler Overflow;
        public int Value;
        public void Increment()
        {
            Value++;

            if (Value == 8)
            {
                Value = 0;
                Overflow?.Invoke(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return "Counter class";
        }
    }

    class Program
    {
        static void Main()
        {
            // Built in delegate: Action
            Action a1 = PrintHello;
            a1(); // "Hello"

            // Action with parameter
            Action<int> a2 = PrintNum;
            a2(3); // "3"

            // Built in delegate: Func
            Func<int> f1 = GiveInt;
            var res = f1();
            Console.WriteLine(res); // "1668617372"

            Func<int, int> f2 = MyFunction;
            var id = f2(23);
            Console.WriteLine(id);

            // Built in delegate: Predicate
            Predicate<int> p1 = GiveBool;
            Console.WriteLine(p1(2)); // True

            // Counter
            Counter ct = new Counter();
            ct.Overflow += (d, e) => Console.WriteLine("Overflow is called from " + d);
            for (int i = 0; i < 9; i++)
            {
                ct.Increment();
                Console.WriteLine(ct.Value);
            }
        }

        static void PrintHello() => Console.WriteLine("Hello");

        static void PrintNum(int i) => Console.WriteLine(i);

        static int GiveInt()
        {
            var rand = new Random();
            return rand.Next();
        }

        static int MyFunction(int age)
        {
            int ID = age + 20;
            Console.WriteLine($"Your ID is:A{ID}"); ;
            return ID;
        }

        static bool GiveBool(int num) => num % 2 == 0;
    }
}
