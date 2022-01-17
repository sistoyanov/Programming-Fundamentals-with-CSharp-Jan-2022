using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headsetPRice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double monitorPrice = double.Parse(Console.ReadLine());

            double totalPrice = (headsetPRice * (games / 2)) + (mousePrice * (games / 3)) + (keyboardPrice * (games / 6)) + (monitorPrice * (games / 12));

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
