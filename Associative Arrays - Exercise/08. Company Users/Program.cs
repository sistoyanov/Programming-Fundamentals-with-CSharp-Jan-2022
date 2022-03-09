using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = inputArg[0];
                string employeeId = inputArg[1];
                
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                List<string> currentCompanyList = companies[companyName];

                if (!currentCompanyList.Contains(employeeId))
                {
                    currentCompanyList.Add(employeeId);
                }

            }

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (string employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
