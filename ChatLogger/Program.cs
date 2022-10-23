using System;
using System.Linq;
using System.Collections.Generic;

namespace ChatLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                if (command[0] == "Chat")
                {
                    chat.Add(command[1]);
                }
                else if(command[0] == "Delete")
                {
                    if (chat.Contains(command[1]))
                    {
                        chat.Remove(command[1]);
                    }
                }
                else if (command[0] == "Edit")
                {
                    if (chat.Contains(command[1]))
                    {
                        int index = chat.IndexOf(command[1]);
                        chat[index] = command[2];
                    }
                }
                else if (command[0] == "Pin")
                {
                    if (chat.Contains(command[1]))
                    {
                        chat.Remove(command[1]);
                        chat.Add(command[1]);

                    }
                }
                else if (command[0] == "Spam")
                {
                    for(int i = 1; i < command.Length; i++)
                    {
                        chat.Add(command[i]);
                    }
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(String.Join(Environment.NewLine, chat));
        }
    }
}
