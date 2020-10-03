using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> participants = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            List<string> songs = Console.ReadLine()
            .Split(", ",StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            List<string> awards = new List<string>();
 
            string command = string.Empty;

            while ((command=Console.ReadLine())!="dawn")
            {
                string[] cmdArgs = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                string song = cmdArgs[1];
                string award = cmdArgs[2];

                if(participants.Contains(name) && songs.Contains(song))
                {

                }

            }

        }
    }

    class Participant
    {
        public string Name { get; set; }
        public List<Awards> Awards;
        public Participant(string name)
        {
            this.Name = name;
            List<Awards> Awards = new List<Awards>();
        }


       
    }
    class Awards
    {
        public string NameAward { get; set; }
    }
}
