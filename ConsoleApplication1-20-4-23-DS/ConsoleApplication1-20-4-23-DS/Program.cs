using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApplication1_20_4_23_DS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] arr1 = { "a", "b", "c" };
            string[] arr2 = { "a", "b", "c" };
            Console.WriteLine(arr1 == arr2); // False
            
            // Finding elements
            string[] cats = { "Tom", "Jerry", "Coklat", "Garfield", "Comel" };
            var match = Array.FindAll(cats, s => s.StartsWith("C"));
            Console.WriteLine(match); // Coklat

            foreach (var meow in match)
            {
                Console.WriteLine(meow);
            }

            // Sorting
            Array.Sort(cats);
            Array.Reverse(cats);
            Console.WriteLine(string.Join(", ", cats));
            
            // Initializing List
            List<string> hariRayaDishes = new List<string>() { "Rendang", "Satay", "Ketupat", };
            
            // Add item to list
            hariRayaDishes.Add("Lontong");
            hariRayaDishes.Add("Dodol");
            
            // Remove item from list
            hariRayaDishes.Remove("Satay");
            // alternatively, remove by index:
            // hariRayaDishes.RemoveAt(1);

            // number of items in list
            Console.WriteLine(hariRayaDishes.Count);

            // check if item exists in list
            hariRayaDishes.Contains("Rendang"); // true
            hariRayaDishes.Contains("Mee Kari"); // false
            
            // print last element
            Console.WriteLine(hariRayaDishes.Last()); // Dodol
        }
    }
}