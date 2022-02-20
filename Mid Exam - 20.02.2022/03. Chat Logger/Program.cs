using System;
using System.Collections.Generic;

namespace _03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chatHistory = new List<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandArg[0];

                if (currentCommand == "Chat")
                {
                    string messageToAdd = commandArg[1];
                    chatHistory.Add(messageToAdd);
                }
                else if (currentCommand == "Delete")
                {
                    string messageToDelete = commandArg[1];

                    if (chatHistory.Contains(messageToDelete))
                    {
                        chatHistory.Remove(messageToDelete);  /// removes only first one
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand == "Edit")
                {
                    string messageToEdit = commandArg[1];
                    string editedmessage = commandArg[2];

                    if (chatHistory.Contains(messageToEdit))
                    {
                        int messageToEditIndex = chatHistory.IndexOf(messageToEdit);
                        chatHistory.RemoveAt(messageToEditIndex);
                        chatHistory.Insert(messageToEditIndex, editedmessage);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand == "Pin")
                {
                    string messageToPin = commandArg[1];

                    if (chatHistory.Contains(messageToPin))
                    {
                        //int messageToPinIndex = chatHistory.IndexOf(messageToPin);
                        chatHistory.Remove(messageToPin);
                        chatHistory.Add(messageToPin);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand == "Spam")
                {
                    for (int i = 1; i < commandArg.Length; i++)
                    {
                        chatHistory.Add(commandArg[i].ToString());
                    }
                }
            }

            foreach (var item in chatHistory)
            {
                Console.WriteLine(item);
            }

        }
    }
}
