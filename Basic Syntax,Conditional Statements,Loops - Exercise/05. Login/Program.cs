using System;
using System.Text;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string user = Console.ReadLine();
            
            //actions
            StringBuilder password = new StringBuilder();
            for (int i = user.Length - 1; i >= 0; i--)
            {
                password.Append(user[i]);
            }

            bool isLoged = false;
            string currentPassword = Console.ReadLine();
            for (int i = 1; i <= 3; i++)
            {
                
                if (password.ToString() == currentPassword)
                {
                    isLoged = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    currentPassword = Console.ReadLine();
                }
                
            }
            
            //output
            Console.WriteLine(isLoged ? $"User {user} logged in." : $"User {user} blocked!");
        }
    }
}
