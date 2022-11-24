using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Piese> pieces = new List<Piese>();

            for (int i = 0; i < count; i++)
            {
                string[] pieceArg = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string currentPieceName = pieceArg[0];
                string currentPieceComposer = pieceArg[1];
                string currentPieceKey = pieceArg[2];

                Piese currentPiece = new Piese(currentPieceName, currentPieceComposer, currentPieceKey);
                pieces.Add(currentPiece);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArg = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArg[0];
                string piece = commandArg[1];

                if (commandType == "Add")
                {
                    string composer = commandArg[2];
                    string key = commandArg[3];

                    if (IsPieceExists(pieces, piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        Piese newPiese = new Piese(piece, composer, key);
                        pieces.Add(newPiese);
                        Console.WriteLine($"{newPiese.Name} by {newPiese.Composer} in {newPiese.Key} added to the collection!");
                    }
                }
                else if (commandType == "Remove")
                {
                    if (IsPieceExists(pieces, piece))
                    {
                        Piese pieseToRemove = pieces.FirstOrDefault(n => n.Name == piece);
                        pieces.Remove(pieseToRemove);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection."); ;
                    }
                }
                else if (commandType == "ChangeKey")
                {
                    string newKey = commandArg[2];

                    if (IsPieceExists(pieces, piece))
                    {
                        Piese pieseToChange = pieces.FirstOrDefault(n => n.Name == piece);
                        pieseToChange.Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection."); ;
                    }
                }
            }

            foreach (Piese piese in pieces)
            {
                Console.WriteLine($"{piese.Name} -> Composer: {piese.Composer}, Key: {piese.Key}");
            }

        }

        static bool IsPieceExists(List<Piese> pieces, string piece)
        {
            if (pieces.Any(n => n.Name == piece))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Piese
    {
        public Piese(string name, string composer, string key)
        {
            this.Name = name;
            this.Composer = composer;
            this.Key = key;
        }
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
