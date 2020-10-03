using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> messages = new Dictionary<string, List<int>>();

            int capacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = command.Split("=");

                if (tokens[0] == "Add")
                {
                    string username = tokens[1];
                    int sentMessages = int.Parse(tokens[2]);
                    int receivedMessages = int.Parse(tokens[3]);

                    if (!messages.ContainsKey(username))
                    {
                        messages.Add(username, new List<int> { sentMessages, receivedMessages });
                    }


                }
                else if (tokens[0] == "Message")
                {
                    string sender = tokens[1];
                    string receiver = tokens[2];

                    if (messages.ContainsKey(sender) && messages.ContainsKey(receiver))
                    {
                        messages[sender][0] += 1;
                        messages[receiver][1] += 1;

                        if ((messages[sender][0] + messages[sender][1]) >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            messages.Remove(sender);
                        }



                        if ((messages[receiver][0] + messages[receiver][1]) >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            messages.Remove(receiver);
                        }

                    }
                    else if (tokens[0] == "Empty")
                    {
                        string username = tokens[1];

                        if (messages.ContainsKey(username))
                        {
                            messages.Remove(username);
                        }
                        else if (username == "All")
                        {
                            messages.Clear();
                        }

                    }



                }

            }

            messages = messages.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Users count: {messages.Count}");

            foreach (var kvp in messages)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value[0] + kvp.Value[1]}");

            }

        }
    }
}
