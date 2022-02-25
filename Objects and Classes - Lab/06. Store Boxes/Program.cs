using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Box
    {
        public Box(string serialNumber, string itemName, double itemQuantity, double itemPrice, double boxPrice)
        {
            SerialNumber = serialNumber;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
            BoxPrice = boxPrice;
        }

        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public double ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public double BoxPrice { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = inputArg[0];
                string itemName = inputArg[1];
                double itemQuantity = double.Parse(inputArg[2]);
                double itemPrice = double.Parse(inputArg[3]);
                double boxPrice = itemQuantity * itemPrice;

                Box currentBox = new Box(serialNumber, itemName, itemQuantity, itemPrice, boxPrice);
                boxes.Add(currentBox);
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(boxes => boxes.BoxPrice).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }

    }
}
