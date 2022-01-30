using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] password = input.ToCharArray();

            int digitCOunter = 0;
            bool isPasswordValid = true;

            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isPasswordValid = false;
            }

            foreach (var item in password)
            {

                if (char.IsLetterOrDigit(item))
                {
                    if (char.IsDigit(item))
                    {
                        digitCOunter++;
                    }
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isPasswordValid = false;
                    break;

                }

            }

            if (digitCOunter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isPasswordValid = false;
            }

            Console.WriteLine(isPasswordValid ? "Password is valid" : "");
        }
    }
}
