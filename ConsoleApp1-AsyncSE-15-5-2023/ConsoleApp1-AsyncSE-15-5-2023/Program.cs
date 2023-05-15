using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1_AsyncSE_15_5_2023
{
    class Program
    {
        static bool done;

        static readonly object locker = new object();
        static AutoResetEvent signal = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            //Thread thread = new Thread(WriteY);
            //thread.Start();
            //thread.Join();

            //Thread t = new Thread(() => { for (int i = 0; i < 10000; i++) Console.Write("z"); }); t.Start();
            //t.Join();

            ////Thread.Sleep(1000);

            //WriteX();

            //new Thread(Go).Start();
            //new Thread(Go).Start();

            new Thread(Waiter).Start(); 
            Thread.Sleep(1000); // Pause for a second...
            signal.Set(); // Wake up the Waiter.

            Console.ReadLine();
        }

        static void Waiter()
        {
            Console.WriteLine("Waiting..."); 
            signal.WaitOne(); // Wait for notification
            Console.WriteLine("Notified");
            Console.Read();
         }

            static void Go() { 
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done");
                    done = true;
                }
            }
             
        }

        static void WriteX()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write('x');
            }
        }

        static void WriteY()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write('y');
            }
        }
    }
}
