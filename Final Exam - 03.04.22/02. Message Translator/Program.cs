using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<message>[A-Za-z]{8,})\]");

            for (int i = 0; i < count; i++)
            {
                string message = Console.ReadLine();
                Match match = regex.Match(message);

                if (match.Success)
                {
                    string command = match.Groups["command"].Value;
                    char[] arrayOfChars = match.Groups["message"].Value.ToCharArray();
                    int[] output = arrayOfChars.Select(a => (int)a).ToArray();

                    Console.WriteLine($"{command}: {string.Join(" ", output)}");

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
            
            
        }
    }
}
