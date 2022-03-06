using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string currentProductName = inputArg[0];
                double currentProductPrice = double.Parse(inputArg[1]);
                double currentProductQty = double.Parse(inputArg[2]);

                if(!products.Any(p => p.Name == currentProductName))
                {
                    products.Add(new Product (currentProductName, currentProductPrice, currentProductQty));
                }
                else
                {
                    Product searchedProduct = products.Find(p => p.Name == currentProductName);

                    searchedProduct.Qty += currentProductQty;

                    if (searchedProduct.Price != currentProductPrice)
                    {
                        searchedProduct.Price = currentProductPrice;
                    }

                }
                
            }

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} -> {(product.Price * product.Qty):f2}");
            }
        }
    }

    class Product
    {
        public Product(string name, double price, double qty)
        {
            this.Name = name;
            this.Price = price;
            this.Qty = qty;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Qty { get; set; }
    }
}
