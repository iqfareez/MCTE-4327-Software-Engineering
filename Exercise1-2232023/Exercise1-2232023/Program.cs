using System;
using System.IO;

/// <summary>
/// Ask user to input string/message
/// Send this string to a function called `Process`
///
/// Process function
///  - Save the message into the text file called `saved.txt`
///
/// Content of saved.txt
/// - Message + Current DateTime
/// 
/// TODO: Add exception handling
/// 
/// </summary>
namespace Exercise1_2232023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a message: (Invoke Ctrl+C to exit)");
            
            // keep asking for input until user exit the program
            for (;;)
            {
                var inputMessage = Console.ReadLine();
                Process(inputMessage);    
            }
        }

        static void Process(string message)
        {
            var messageContent = $"{DateTime.Now}: {message}";
            var filePath = @"saved.txt";

            try
            {
                // Check if the file exists and create it if it doesn't
                if (!File.Exists(filePath))
                {
                    using StreamWriter sw = File.CreateText(filePath);
                    sw.WriteLine(messageContent);
                }
                else
                {
                    // Append the content to the existing file
                    File.AppendAllText(filePath, messageContent+"\n");
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"File locked.");
            }
        }
    }
}
