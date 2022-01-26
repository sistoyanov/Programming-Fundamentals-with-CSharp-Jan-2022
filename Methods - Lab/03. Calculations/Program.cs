using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(numA, numB);    
                    break;
                case "multiply":
                    Multiply(numA, numB);
                    break;
                case "subtract":
                    Subtract(numA, numB);
                    break;
                case "divide":
                    Divide(numA, numB);
                    break;
            }
            
        }
        static void Add(double numA, double numB)
        {
          Console.WriteLine(numA + numB);
        }
       

        static void Multiply(double numA, double numB)
        { 
         Console.WriteLine(numA * numB);
        } 
          
        static void Subtract(double numA, double numB)
        { 
         Console.WriteLine(numA - numB);
        } 
          
        static void Divide(double numA, double numB)
        {
         Console.WriteLine(numA / numB);
        }


    }
}
