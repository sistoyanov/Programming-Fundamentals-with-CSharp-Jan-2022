using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string digit = Console.ReadLine();
                int firstDigit = int.Parse(digit[0].ToString());
                int offset = (firstDigit - 2) * 3;
               

                if (firstDigit == 0)
                {
                    word += (char)32;
                    continue;
                }

                if (firstDigit == 8 || firstDigit == 9)
                {
                    offset++;
                }

                int index = (offset + digit.Length - 1);
                word += (char)(index + 97);
            }

            Console.WriteLine(word);
        }
    }
}
