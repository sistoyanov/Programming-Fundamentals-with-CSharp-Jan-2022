using System;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder validUsernames = new StringBuilder();
            bool isUsernameValid = true;

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    
                    foreach (char item in username)
                    {
                        
                        if (char.IsLetterOrDigit(item) || item.Equals('-') || item.Equals('_'))
                        {
                            isUsernameValid = true;
                        }
                        else
                        {
                            isUsernameValid = false;
                            break;
                        }

                    }

                    if (isUsernameValid)
                    {
                        validUsernames.AppendLine(username);
                    }

                }
                
            }

            Console.WriteLine(validUsernames);
        }
    }
}
