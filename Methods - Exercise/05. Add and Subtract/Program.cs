using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Substract(a, b, c));
        }

        static int Substract(int a, int b, int c)
        {
           int filnalResult = Add(a, b) - c;
           return filnalResult;
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

    }
}
