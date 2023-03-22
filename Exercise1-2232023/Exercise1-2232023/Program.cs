using System;

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

            var inputMessage = Console.ReadLine();

            process(inputMessage);
        }

        static void process(string message)
        {
            System.IO.File.WriteAllText("@../../../saved.txt", DateTime.Now.ToString() + message);
        }
    }
}
