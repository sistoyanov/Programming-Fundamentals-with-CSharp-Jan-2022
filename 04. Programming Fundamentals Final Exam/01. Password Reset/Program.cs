using System;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];

                if(commandType == "TakeOdd")
                {
                    char[] oddChars = password.Where((x, i) => i % 2 != 0).ToArray();
                    password = String.Join("", oddChars);
                    Console.WriteLine(password);
                }
                else if (commandType == "Cut")
                {
                    int index = int.Parse(commandArg[1]);
                    int lenght = int.Parse(commandArg[2]);
                    //string newSubString = password.Substring(index, lenght);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);

                }
                else if (commandType == "Substitute")
                {
                    string subString = commandArg[1];
                    string subStitute = commandArg[2];

                    if (password.Contains(subString))
                    {
                        password = password.Replace(subString, subStitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
