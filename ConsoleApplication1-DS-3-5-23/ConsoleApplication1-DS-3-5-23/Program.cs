using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1_DS_3_5_23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // LinkedList
            LinkedList<string> hariRayaDishes = new LinkedList<string>();
            hariRayaDishes.AddLast("Rendang");
            hariRayaDishes.AddLast("Satay");
            hariRayaDishes.AddLast("Ketupat");

            // Add item to list
            hariRayaDishes.AddLast("Dodol");
            hariRayaDishes.AddAfter(hariRayaDishes.First.Next.Next, "Lemang");
            // alternatively, find specific node and add after it:
            // hariRayaDishes.AddAfter(hariRayaDishes.Find("Satay"), "Lemang");
            
            // Remove item from list
            hariRayaDishes.Remove("Satay");

            // number of items in list
            Console.WriteLine(hariRayaDishes.Count);

            // check if item exists in list
            hariRayaDishes.Contains("Rendang"); // true
            hariRayaDishes.Contains("Mee Kari"); // false
            
            // Queue
            Queue<string> ticketQueue = new Queue<string>();
        
            // Adding tickets to the queue
            ticketQueue.Enqueue("Ticket #1");
            ticketQueue.Enqueue("Ticket #2");
            ticketQueue.Enqueue("Ticket #3");
            
            // Check who come next without dequeuing it
            var tempTicket = ticketQueue.Peek();
        
            // Serving tickets in the queue
            while (ticketQueue.Count > 0)
            {
                // ticket will assigned to the topmost element
                string ticket = ticketQueue.Dequeue();
                Console.WriteLine($"Serving ticket: {ticket}");
            }
            
            // Stack
            Stack<string> browserStack = new Stack<string>();
            browserStack.Push("https://www.google.com");
            browserStack.Push("https://www.facebook.com");

            // Simulating a user browsing history
            Console.WriteLine("User is currently on: " + browserStack.Peek());
            browserStack.Push("https://www.linkedin.com");
            Console.WriteLine("User visited: " + browserStack.Peek());

            // Implementing the back button functionality
            Console.WriteLine("User clicked back button...");
            browserStack.Pop();
            Console.WriteLine("User is currently on: " + browserStack.Peek());
            
            // Dictionary
            Dictionary<int, string> names = new Dictionary<int, string>();

            // Add some names and ID to the dictionary
            names.Add(143, "Alice");
            names.Add(211, "Bob");
            names.Add(342, "Charlie");

            // Retrieve a name using its ID
            string name = names[342];

            // Remove a name from the dictionary
            names.Remove(211);
            
            // Check if a key exists in the dictionary
            if (names.ContainsKey(143))
            {
                Console.WriteLine("ID 143 belongs to: " + names[143]);
            }

            // Iterate over the remaining names in the dictionary
            foreach (KeyValuePair<int, string> kvp in names)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}