using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int initialN = n;
            int counter = 0;

            while (m <= n)
            {
                n -= m;
                counter++;

                if (n == initialN / 2 && y > 0)
                {
                    n /= y;
                }
                
            }

            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
