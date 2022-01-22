using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int openBracketsCount = 0;
            int closingBracketsCount = 0;

            for (int i = 1; i <= count; i++)
            {
                string inpput = Console.ReadLine();
                
                if (char.TryParse(inpput, out char bracket))
                {
                    if (bracket == 40)
                    {
                        openBracketsCount++;
                    }
                    else if (bracket == 41)
                    {
                        closingBracketsCount++;

                        if (openBracketsCount - closingBracketsCount != 0)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(openBracketsCount == closingBracketsCount ? "BALANCED" : "UNBALANCED");
        }
    }
}
