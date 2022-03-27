using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArg = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];

                if (commandType == "Add Stop")
                {
                    int index = int.Parse(commandArg[1]);
                    string newString = commandArg[2];

                    if (IsIndexValid(stops, index))
                    {
                        stops = stops.Insert(index, newString);
                    }

                    Console.WriteLine(stops);
                }
                else if (commandType == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);

                    if (IsIndexValid(stops, startIndex) && IsIndexValid(stops, endIndex))
                    {
                        int count = (endIndex - startIndex) + 1;
                        stops = stops.Remove(startIndex, count);
                    }

                    Console.WriteLine(stops);
                }
                else if (commandType == "Switch")
                {
                    string oldString = commandArg[1];
                    string newString = commandArg[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }

                    Console.WriteLine(stops);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }

        static bool IsIndexValid (string stops, int index)
        {
            return index >= 0 && index < stops.Length;
        }
    }
}
