using System;

/// <summary>
/// - Static class & functipn
/// - Operator overloading
/// </summary>
namespace ConsoleApp2_OOP_2_3_23
{
    /// <summary>
    /// Demo static class
    /// </summary>
    class CounterClass
    {
        private static int counter = 0;

        static public void IncrementCounter() => counter += 1;

        static public void Print() => Console.WriteLine(counter);
    }

    /// <summary>
    /// Operator overloading demo
    /// </summary>
    class Vector2
    {
        private double x;
        private double y;

        public Vector2(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public static Vector2 operator+(Vector2 A, Vector2 B)
        {
            return new Vector2(A.x + B.x, A.y + B.y);
        }

        public override string ToString()
        {
            return $"Vector({x}, {y})";
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            // Print initial value
            CounterClass.Print(); // 0

            // Increment counter
            CounterClass.IncrementCounter();
            CounterClass.IncrementCounter();

            // Print current value
            CounterClass.Print(); // 2

            DisplayText(); // Haiii

            var v1 = new Vector2(10, -3);
            var v2 = new Vector2(-4, 40);

            var vRes = v1 + v2;
            Console.WriteLine(vRes); // Vector(6, 37)

        }
        
        /// <summary>
        /// Demo static class
        /// </summary>
        static void DisplayText() => Console.WriteLine("Haiii");
    }
}
