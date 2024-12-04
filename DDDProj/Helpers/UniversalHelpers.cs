using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProj.Helpers
{

    public static class UniversalHelpers
    {
        public static bool loggedOn { get; set; }
        public static string loggedInUser {  get; set; }
        
        public static int GetIntegerInRange(int pMin, int pMax, string pMessage)
        {
            if (pMin > pMax)
            {
                throw new Exception($"Minimum value {pMin} cannot be greater than maximum value {pMax}");
            }

            int result;

            do
            {
                Console.WriteLine(pMessage);
                Console.WriteLine($"Please enter a number between {pMin} and {pMax} inclusive");

                string userInput = Console.ReadLine();

                try
                {
                    result = int.Parse(userInput);
                }
                catch
                {
                    Console.WriteLine($"{userInput} is not a number");
                    continue;
                }

                if (result >= pMin && result <= pMax)
                {
                    return result;
                }
                Console.WriteLine($"{result} is not between {pMin} and {pMax} inclusive.");
            } while (true);
        }

        public static string ValidString(string pInputRequest)
        {
            string validCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            do
            {
                try
                {
                    Console.WriteLine(pInputRequest); string input = Console.ReadLine();

                    foreach (char iChar in input)
                    {
                        if (validCharacters.Contains(iChar))
                        {
                            return input;
                        }
                    }
                    throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }
            } while (true);
        }

        public static bool BoolAnswer(string pInputRequest)
        {
            Console.WriteLine(pInputRequest);
            Console.WriteLine("\nPlease enter 'Y' for yes and 'N' for no"); string input = Console.ReadLine().ToUpper();

            do
            {
                try
                {
                    if (input == "Y")
                    {
                        return true;
                    }
                    else if (input == "N")
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            } while (true);

        }
    }


}
