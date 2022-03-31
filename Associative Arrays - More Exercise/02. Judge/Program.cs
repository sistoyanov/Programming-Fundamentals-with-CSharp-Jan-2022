using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Contest> contestList = new List<Contest>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] contestDetails = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string userName = contestDetails[0];
                string contestName = contestDetails[1];
                int contestPoints = int.Parse(contestDetails[2]);

                if (!contestList.Any(n => n.Name == contestName))
                {
                    contestList.Add(new Contest(contestName));
                }

                Contest existingContest = contestList.FirstOrDefault(n => n.Name == contestName);

                if (existingContest.Users.ContainsKey(userName))
                {
                    if (existingContest.Users[userName] < contestPoints)
                    {
                        existingContest.Users[userName] = contestPoints;
                    }
                }
                else
                {
                    existingContest.Users.Add(userName, contestPoints);
                }

            }

            Dictionary<string, int> allUsers = AddUserStatistics(contestList);

            foreach (Contest contest in contestList)
            {
                Console.WriteLine($"{contest.Name}: {contest.Users.Count} participants");
                Dictionary<string, int> currentUsers = contest.Users;
                currentUsers = currentUsers.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                for (int i = 0; i < currentUsers.Count; i++)
                {
                    var kvp = currentUsers.ElementAt(i);
                    Console.WriteLine($"{i + 1}. {kvp.Key} <::> {kvp.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            allUsers = allUsers.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            for (int i = 0; i < allUsers.Count; i++)
            {
                var kvp = allUsers.ElementAt(i);
                Console.WriteLine($"{i + 1}. {kvp.Key} -> {kvp.Value}");
            }

        }

        static Dictionary<string, int> AddUserStatistics (List<Contest> contestList)
        {
            Dictionary<string, int> newDictionary = new Dictionary<string, int>();

            foreach (Contest contest in contestList)
            {
                Dictionary<string, int> currentUsers = contest.Users;

                foreach (var kvp in currentUsers)
                {

                    if (newDictionary.ContainsKey(kvp.Key))
                    {
                        newDictionary[kvp.Key] += kvp.Value;
                    }
                    else
                    {
                        newDictionary.Add(kvp.Key, kvp.Value);
                    }
                }
            }

            return newDictionary;
        }
    }

    class Contest
    {
        public Contest(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public Dictionary<string, int> Users { get; set; } = new Dictionary<string, int>();
    }
}
