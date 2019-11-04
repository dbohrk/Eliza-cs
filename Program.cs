using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Doctor.Intro());

            var userInput = "";
            while(!userInput.Equals("bye", StringComparison.OrdinalIgnoreCase))
            {
                userInput = Console.ReadLine();
                string response = Doctor.response(userInput);
                Console.WriteLine(response);
            }

        }
    }
}