using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArg = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];

                if (commandType == "Contains")
                {
                    string subString = commandArg[1];

                    if (activationKey.Contains(subString))
                    {
                        Console.WriteLine($"{activationKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commandType == "Flip")
                {
                    string upperOrLower = commandArg[1];
                    int startIdx = int.Parse(commandArg[2]);
                    int endIdx = int.Parse(commandArg[3]);

                    string stringToChange = activationKey.Substring(startIdx, endIdx - startIdx);
                    string newSubStr = string.Empty;

                    if (upperOrLower == "Upper")
                    {
                        newSubStr = stringToChange.ToUpper();
                    }
                    else
                    {
                       newSubStr = stringToChange.ToLower();
                    }

                    activationKey = activationKey.Replace(stringToChange, newSubStr);
                    Console.WriteLine(activationKey);
                }
                else if (commandType == "Slice")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
