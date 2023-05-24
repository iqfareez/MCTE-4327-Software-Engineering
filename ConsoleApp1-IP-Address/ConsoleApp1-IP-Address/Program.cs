using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress a1 = IPAddress.Any;
            Console.WriteLine(a1); // 0.0.0.0

            IPAddress a2 = IPAddress.Loopback;
            Console.WriteLine(a2); // 127.0.0.1

            IPEndPoint endpoint = new IPEndPoint(a2, 80);
            Console.WriteLine(endpoint);


            Console.ReadLine();

        }
    }
}
