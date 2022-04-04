using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            List<Player> players = new List<Player>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] inputArg = input.Split(new string[] { " -> ", " vs "}, StringSplitOptions.RemoveEmptyEntries);

                if (inputArg.Length <= 2)
                {
                    string playerOne = inputArg[0];
                    string playerTwo = inputArg[1];

                    PlayerDuel(players, playerOne, playerTwo);
                }
                else
                {
                    string playerName = inputArg[0];
                    string playerPosition = inputArg[1];
                    int playerSkill = int.Parse(inputArg[2]);

                    AddPlayer(players, playerName, playerPosition, playerSkill);
                }
            }

            Dictionary<string, int> finalPlayers = new Dictionary<string, int>();

            foreach (Player player in players)
            {
                string currentPlayer = player.Name;
                int currentPlayerScore = PlayerSkillScore(players, currentPlayer);
                finalPlayers.Add(currentPlayer, currentPlayerScore);
            }

            finalPlayers = finalPlayers.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            
            foreach (var playerKVP in finalPlayers)
            {
                Console.WriteLine($"{playerKVP.Key}: {playerKVP.Value} skill");

                Player playerToPrint = players.FirstOrDefault(n => n.Name == playerKVP.Key);
                Dictionary<string, int> playerToPrintLevels = playerToPrint.Level;
                playerToPrintLevels = playerToPrintLevels.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var playerToPRintKVP in playerToPrintLevels)
                {
                    Console.WriteLine($"- {playerToPRintKVP.Key} <::> {playerToPRintKVP.Value}");
                }
            }

        }

        static void AddPlayer (List<Player> players, string playerName, string playerPosition, int playerSkill)
        {
            Dictionary<string, int> levelToAdd = new Dictionary<string, int>() { { playerPosition, playerSkill } };
            Player playerToAdd = new Player(playerName, levelToAdd);

            if (!players.Any(n => n.Name == playerName))
            {
                players.Add(playerToAdd);
            }
            else
            {
                Player existingPlayer = players.FirstOrDefault(n => n.Name == playerName);
                Dictionary<string, int> existingPlayerLevel = existingPlayer.Level;

                if (existingPlayer.Level.ContainsKey(playerPosition))
                {
                    if (existingPlayerLevel[playerPosition] < playerSkill)
                    {
                        existingPlayerLevel[playerPosition] = playerSkill;
                    }
                }
                else
                {
                    existingPlayer.Level.Add(playerPosition, playerSkill);
                }

            }
        }

        static void PlayerDuel (List<Player> players, string playerOne, string playerTwo)
        {
            Player firstPlayer = players.FirstOrDefault(n => n.Name == playerOne);
            Player secondPlayer = players.FirstOrDefault(n => n.Name == playerTwo);

            if (firstPlayer != null && secondPlayer != null)
            {
                Dictionary<string, int> firstPlayerLevels = firstPlayer.Level;
                Dictionary<string, int> secondPlayerLevels = secondPlayer.Level;
                bool duel = false;

                foreach (var firstKVP in firstPlayerLevels)
                {
                    var firstPlayerKey = firstKVP.Key;

                    foreach (var secondKVP in secondPlayerLevels)
                    {
                        var secondPlayerKey = secondKVP.Key;

                        if (firstPlayerKey == secondPlayerKey)
                        {
                            duel = true;
                            break;
                        }
                    }
                }

                if (duel)
                {
                    int firstPlayerSkills = PlayerSkillScore(players, playerOne);
                    int secondPlayerSkills = PlayerSkillScore(players, playerTwo);

                    if (firstPlayerSkills > secondPlayerSkills)
                    {
                        players.Remove(secondPlayer);
                    }
                    else if (secondPlayerSkills > firstPlayerSkills)
                    {
                        players.Remove(firstPlayer);
                    }
                }
            }
        }

        static int PlayerSkillScore (List<Player> players, string playerToFindName)
        {
            Player searchedPlayer = players.FirstOrDefault(n => n.Name == playerToFindName);
            Dictionary<string , int> searchedPlayerLevels = searchedPlayer.Level;
            return searchedPlayerLevels.Sum(x => x.Value);
        }
    }

    class Player
    {
        public Player(string name, Dictionary<string, int> level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name { get; set; }
        public Dictionary<string, int> Level { get; set; }
    }
}


