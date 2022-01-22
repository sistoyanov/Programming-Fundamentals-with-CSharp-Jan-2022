using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 1; i <= count; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int newSymbol = symbol + key;
                message += (char)newSymbol;
            }

            Console.WriteLine(message);
        }
    }
}
