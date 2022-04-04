using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = string.Empty;
            

            while ((input = Console.ReadLine()) != "find")
            {
                string message = input;
                StringBuilder output = new StringBuilder();
                int keyIdx = -1;
                int counter = 1;

                for (int i = 0; i < message.Length; i++)
                {
                    
                    if (i >= counter * key.Length)
                    {
                        keyIdx = i - (counter * key.Length);
                        counter++;
                    }
                    else
                    {
                        keyIdx ++;
                    }

                    output.Append((char)(message[i] - key[keyIdx]));

                }
            }
        }
    }
}
