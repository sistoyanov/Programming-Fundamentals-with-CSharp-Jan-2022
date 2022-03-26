using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = string.Empty;

            while((commands = Console.ReadLine()) != "Decode")
            {
                string[] commandArg = commands.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = commandArg[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(commandArg[1]);
                    string lettersToMove = input.Substring(0, numberOfLetters);
                    input = input.Remove(0, numberOfLetters);
                    input = input + lettersToMove;
                }
                else if (command == "Insert")
                {
                    int idxToInsert = int.Parse(commandArg[1]);
                    string valueToInsert = commandArg[2];
                    input = input.Insert(idxToInsert, valueToInsert);
                }
                else if (command == "ChangeAll")
                {
                    string stringToReplace = commandArg[1];
                    string newString = commandArg[2];
                    input = input.Replace(stringToReplace, newString);
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
