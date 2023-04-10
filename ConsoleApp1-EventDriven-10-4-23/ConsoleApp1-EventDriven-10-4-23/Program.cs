using System;

namespace ConsoleApp1_EventDriven_10_4_23
{
    class Program
    {
        public delegate int Transformer(int x);
        public delegate int Add(int x, int y);

        public delegate bool DelegateBool(int x);
        public delegate void DelegateVoid(int x, int y);
        public delegate void Delegatehi();
        public delegate int Delegatee(int x, int y, int z);

        static void Main(string[] args)
        {
            // Method 1 : Anonymous method
            Transformer a = delegate (int x) { return x * x; };
            int ans = a(3);
            Console.WriteLine(ans); // 9

            // Method 2: Lambda expression
            Transformer b = x => x * x;
            var ans2 = b(3);
            Console.WriteLine(ans2); // 9

            // Lambda with multiple parameters
            Add c = (a, b) => a + b;
            var ans3 = c(1, 6);
            Console.WriteLine(ans3); // 7

            // Exercises
            // #1
            DelegateBool w = a => a > 50;
            var ansBool = w(40);
            Console.WriteLine(ansBool);

            
            // #2
            DelegateVoid r = (a, b) => Console.WriteLine(a + "," + b);
            r(3, 5); // 3,5

            // #3
            Delegatehi t = () => Console.WriteLine("Hi");
            t(); // Hi

            // #4
            Delegatee m = (a, b, c) =>
            {
                if (a > b && a > c) return a;
                else if (b > a && b > c) return b;
                else return c;
            };

            var anss = m(10, 20, 30);
            Console.WriteLine(anss);
        }
    }
}
