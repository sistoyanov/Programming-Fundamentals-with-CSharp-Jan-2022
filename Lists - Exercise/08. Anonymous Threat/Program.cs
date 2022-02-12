using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            //Console.WriteLine(String.Join("", words));

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commandArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandArg[0];  

                if (currentCommand == "merge")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);

                    Merge(words, startIndex, endIndex);
                }
                else if (currentCommand == "divide")
                {
                    int index = int.Parse(commandArg[1]);
                    int partitionsCount = int.Parse(commandArg[2]);

                    Divide(words, index, partitionsCount);
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }

        static void Divide(List<string> words, int index, int partitionsCount)
        {
            string currentWord = words[index];
            int partitionsLenght = currentWord.Length / partitionsCount;
            int lastPartitionLenght = (currentWord.Length % partitionsCount) + partitionsLenght;

            List<string> partitions = new List<string>();

            for (int i = 0; i < partitionsCount; i++)
            {
                string currentPartitionString = string.Empty;

                if (i == partitionsCount - 1)
                {
                    currentPartitionString = currentWord.Substring(i * partitionsLenght, lastPartitionLenght);
                }
                else
                {
                    currentPartitionString = currentWord.Substring(i * partitionsLenght, partitionsLenght);
                }

                partitions.Add(currentPartitionString);
            }

            words.RemoveAt(index);
            words.InsertRange(index, partitions);
        }

        static bool IsIndexValid (List<string> word, int idex)
        {
            if (idex < 0 || idex > word.Count - 1)
            {
                return false;
            }

            return true;
        }

        static void Merge (List<string> words, int startIndex, int endIndex)
        {
            if (!IsIndexValid(words, startIndex))
            {
                startIndex = 0;
            }

            if (!IsIndexValid(words, endIndex))
            {
                endIndex = words.Count - 1;
            }

            StringBuilder merged = new StringBuilder();

            for (int counter = startIndex; counter <= endIndex; counter++)
            {
                merged.Append(words[startIndex]);
                words.RemoveAt(startIndex);
            }

            words.Insert(startIndex, merged.ToString());
        }
    }
}
