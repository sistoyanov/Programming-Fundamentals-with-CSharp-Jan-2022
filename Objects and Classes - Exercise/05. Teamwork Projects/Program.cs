using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 1; i <= count; i++)
            {
                string[] teamDetails = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creatorName = teamDetails[0];
                string teamName = teamDetails[1];

                if (IsTeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (IsCreatorExists(teams, creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
 
                }
                else
                {
                    teams.Add(new Team(creatorName, teamName));
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] memberDetails = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string memberName = memberDetails[0];
                string teamNameToJoin = memberDetails[1];

                Team teamToJoin = teams.FirstOrDefault(t => t.TeamName == teamNameToJoin);

                if (!IsTeamExists(teams, teamNameToJoin))
                {
                    Console.WriteLine($"Team {teamNameToJoin} does not exist!");
                }
                else if (IsMemberExists(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamNameToJoin}!");
                }
                else
                {
                    teamToJoin.AddMember(memberName);
                }
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            List<Team> invalidTeams = teams.Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine(validTeam.TeamName);
                Console.WriteLine($"- {validTeam.CreatorName}");

                foreach (string currentMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currentMember}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team invalidTeam in invalidTeams)
            {
                Console.WriteLine($"{invalidTeam.TeamName}");
            }

            static bool IsTeamExists(List<Team> teams, string teamName)
            {
                if (teams.Any(t => t.TeamName == teamName))
                {
                    return true;
                }

                return false;
            }

            static bool IsCreatorExists(List<Team> teams, string creatorName)
            {
                if (teams.Any(c => c.CreatorName == creatorName))
                {
                    return true;
                }

                return false;
            }

            static bool IsMemberExists(List<Team> teams, string memberName)
            {
                foreach (Team team in teams)
                {
                    if (team.Members.Contains(memberName))
                    {
                        return true;
                    }

                    if (team.CreatorName == memberName)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
    

    class Team
    {
        public Team(string creatorName, string teamName)
        {
            this.CreatorName = creatorName;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
}
