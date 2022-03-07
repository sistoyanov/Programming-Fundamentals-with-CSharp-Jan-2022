using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string[] inputArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = inputArg[0];
                string username = inputArg[1];

                if (command == "register")
                {
                    string licensePlate = inputArg[2];

                    if (parkingRegister.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingRegister[username]}");
                    }
                    else
                    {
                        parkingRegister.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parkingRegister.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingRegister.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in parkingRegister)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
