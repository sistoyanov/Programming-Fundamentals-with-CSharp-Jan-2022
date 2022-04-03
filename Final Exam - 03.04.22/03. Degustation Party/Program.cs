using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Guest> guests = new List<Guest>();
            int unlikes = 0;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArg = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                string guestName = commandArg[1];
                string meal = commandArg[2];

                if (commandType == "Like")
                {
                    if (!guests.Any(n => n.Name == guestName))
                    {
                        guests.Add(new Guest(guestName));
                    }

                    Guest likeGuest = SearchedGuest(guests, guestName);

                    if (!likeGuest.Meals.Contains(meal))
                    {
                        likeGuest.Meals.Add(meal);
                    }
                }
                else if (commandType == "Dislike")
                {
                    if (guests.Any(n => n.Name == guestName))
                    {
                        Guest disLikeGuest = SearchedGuest(guests, guestName);

                        if (disLikeGuest.Meals.Contains(meal))
                        {
                            unlikes ++;
                            disLikeGuest.Meals.Remove(meal);
                            Console.WriteLine($"{guestName} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                }
            }

            foreach (Guest guest in guests)
            {
                Console.WriteLine($"{guest.Name}: {string.Join(", ", guest.Meals)}");
            }
            Console.WriteLine($"Unliked meals: {unlikes}");
        }

        static Guest SearchedGuest (List<Guest> guests, string guestName)
        {
            Guest searchGuest = guests.FirstOrDefault(n => n.Name == guestName);
            return searchGuest;
        }
    }

    class Guest
    {
        public Guest(string name)
        {
            this.Name = name;
            this.Meals = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Meals { get; set; }
    }
}
