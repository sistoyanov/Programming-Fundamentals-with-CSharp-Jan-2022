using System;

namespace _01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];

                if (commandType == "Replace")
                {
                    string currentChar = commandArg[1];
                    string newChar = commandArg[2];

                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (commandType == "Cut")
                {
                    int cutStartIdx = int.Parse(commandArg[1]);
                    int cutEndIdx = int.Parse(commandArg[2]);

                    if (CheckIdx(message, cutStartIdx, cutEndIdx))
                    {
                        message = message.Remove(cutStartIdx, (cutEndIdx - cutStartIdx) + 1);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }
                else if (commandType == "Make")
                {
                    string upperOrLower = commandArg[1];

                    if (upperOrLower == "Upper") ///?
                    {
                        message = message.ToUpper();
                    }
                    else
                    {
                        message = message.ToLower();
                    }

                    Console.WriteLine(message);
                }
                else if (commandType == "Check")
                {
                    string subString = commandArg[1];

                    if (message.Contains(subString))
                    {
                        Console.WriteLine($"Message contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {subString}");
                    }
                }
                else if (commandType == "Sum")
                {
                    int sumStartIdx = int.Parse(commandArg[1]);
                    int sumEndIdx = int.Parse(commandArg[2]);

                    if (CheckIdx(message, sumStartIdx, sumEndIdx))
                    {
                        int sum = 0;
                        char[] arrayOfChars = message.Substring(sumStartIdx, (sumEndIdx - sumStartIdx) + 1).ToCharArray();

                        foreach (char item in arrayOfChars)
                        {
                            sum += item;
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }

        static bool CheckIdx (string message, int startIdx, int endIdx)
        {
            if (startIdx < 0 || endIdx > message.Length - 1)
            {
                return false;
            }

            return true;
        }
    }

}
