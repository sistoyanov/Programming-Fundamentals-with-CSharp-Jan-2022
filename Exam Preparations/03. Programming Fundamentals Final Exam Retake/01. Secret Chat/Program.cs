using System;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandArg = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];

                if (commandType == "InsertSpace")
                {
                    int index = int.Parse(commandArg[1]);

                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (commandType == "Reverse")
                {
                    string subString = commandArg[1];

                    if (message.Contains(subString))
                    {
                        int startIdx = message.IndexOf(subString);
                        int endIdx = startIdx + subString.Length;
                        int count = endIdx - startIdx;


                        char[] charArray = subString.ToCharArray();
                        Array.Reverse(charArray);
                        string reversedString = new string(charArray);

                        message = message.Remove(startIdx, count);
                        message = message + reversedString;

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType == "ChangeAll")
                {
                    string stringToReplace = commandArg[1];
                    string replacment = commandArg[2];

                    message = message.Replace(stringToReplace, replacment);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
