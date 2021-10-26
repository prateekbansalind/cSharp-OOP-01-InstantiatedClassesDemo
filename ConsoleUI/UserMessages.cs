using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class UserMessages
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }


        public static int GetAInteger(string message)
        {
            Console.Write(message);
            string outputText = Console.ReadLine();

            bool isValidOutput;

            isValidOutput = int.TryParse(outputText, out int output);

            while (isValidOutput == false)
            {
                Console.Write(message);
                outputText = Console.ReadLine();

                isValidOutput = int.TryParse(outputText, out output);
            }

            return output;

        }
    }
}
