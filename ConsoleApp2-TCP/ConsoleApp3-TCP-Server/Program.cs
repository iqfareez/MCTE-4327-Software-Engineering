using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_TCP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpConnect();
        }

        static async void TcpConnect()
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Any, 13);
            TcpListener listener = new TcpListener(ipEndPoint);

            try
            {
                listener.Start();

                TcpClient handler = await listener.AcceptTcpClientAsync();
                await using NetworkStream stream = handler.GetStream();

                var message = $"📅 {DateTime.Now} 🕛";
                var dateTimeBytes = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(dateTimeBytes);

                Console.WriteLine($"Sent message: \"{message}\"");
                // Sample output:
                //     Sent message: "📅 8/22/2022 9:07:17 AM 🕛"
            }
            finally
            {
                listener.Stop();
            }
        }
    }
}
