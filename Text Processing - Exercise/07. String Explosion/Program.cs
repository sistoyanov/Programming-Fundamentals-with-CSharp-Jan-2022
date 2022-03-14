using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = Console.ReadLine().ToList();
            StringBuilder output = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < chars.Count; i++)
            {

                char currentChar = chars[i];

                if (currentChar == '>')
                {
                    int currentBombPower = (int)chars[i + 1] - '0';
                    output.Append(currentChar);
                    bombPower += currentBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        output.Append(currentChar);
                    }
                }

            }

            Console.WriteLine(output);


            //for (int i = 0; i < chars.Count; i++)
            //{

            //    if (bombPower > 0 && chars[i] != '>')
            //    {
            //        chars.RemoveAt(i);
            //        bombPower--;
            //        i--;
            //    }
            //    else if (chars[i] == '>')
            //    {
            //        bombPower += int.Parse(chars[i + 1].ToString());
            //    }

            //}

            //Console.WriteLine(String.Join("", chars));
        }
    }
}
