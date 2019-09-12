using System;
using System.Linq;
using System.Collections.Generic;

namespace _07TheVLogger
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split();

            var vloggersFollowersFollows = new Dictionary<string, SortedSet<string>[]>();

            while (command[0] != "Statistics")
            {
                if (command[1] == "joined"
                 && !vloggersFollowersFollows.ContainsKey(command[0]))
                {
                    string vlogger = command[0];
                    var followers = new SortedSet<string>();
                    var follows = new SortedSet<string>();
                    var followersFollows = new SortedSet<string>[2] { followers, follows };
                    vloggersFollowersFollows.Add(vlogger, followersFollows);
                }
                if (command[1] == "followed"
                 && vloggersFollowersFollows.ContainsKey(command[0])
                 && vloggersFollowersFollows.ContainsKey(command[2])
                 && command[0] != command[2])
                {
                    string vlogger = command[2];
                    string follower = command[0];

                  //vloggersFollowersFollows[vlogger][0] <=> Followers
                  //vloggersFollowersFollows[vlogger][1] <=> Follows
                    vloggersFollowersFollows[vlogger][0].Add(follower);
                    vloggersFollowersFollows[follower][1].Add(vlogger);
                }
                command = Console.ReadLine().Split();
            }
            vloggersFollowersFollows = vloggersFollowersFollows
                .OrderByDescending(x => x.Value[0].Count)
                .ThenBy(x => x.Value[1].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"The V-Logger has a total of " +
                $"{vloggersFollowersFollows.Count} vloggers in its logs.");

            int counter = 1;
            foreach (var followers in vloggersFollowersFollows)
            {
                Console.WriteLine($"{counter}. {followers.Key} : " +
                    $"{followers.Value[0].Count} followers, " +
                    $"{followers.Value[1].Count} following");
                if (counter == 1)
                {
                    foreach (var follower in followers.Value[0])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
        }
    }
}
