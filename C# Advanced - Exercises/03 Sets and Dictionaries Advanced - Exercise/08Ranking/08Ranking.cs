using System;
using System.Linq;
using System.Collections.Generic;

namespace _08Ranking
{
    class Program
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            var contestPassword = new List<string>();

            while (input1 != "end of contests")
            {
                contestPassword.Add(input1);

                input1 = Console.ReadLine();
            }
            string[] input2 = Console.ReadLine().Split("=>");
            var usernameContestPasswordPoints = new Dictionary<string, Dictionary<string, int>>();

            while (input2[0] != "end of submissions")
            {
                string contest = input2[0];
                string password = input2[1];

                string contestAndPassword = contest + ":" + password;

                if (contestPassword.Contains(contestAndPassword))
                {
                    string username = input2[2];
                    int points = int.Parse(input2[3]);

                    if (!usernameContestPasswordPoints.ContainsKey(username))
                    {
                        var contestPasswordPoints = new Dictionary<string, int>();
                        contestPasswordPoints.Add(contestAndPassword, points);

                        usernameContestPasswordPoints.Add(username, contestPasswordPoints);
                    }
                    else if (!usernameContestPasswordPoints[username].ContainsKey(contestAndPassword))
                    {
                        usernameContestPasswordPoints[username].Add(contestAndPassword, points);
                    }
                    else if (usernameContestPasswordPoints[username][contestAndPassword] < points)
                    {
                        usernameContestPasswordPoints[username][contestAndPassword] = points;
                    }
                }
                input2 = Console.ReadLine().Split("=>");
            }
            string bestCandidate = string.Empty;
            int bestPoints = 0;

            foreach (var user in usernameContestPasswordPoints)
            {
                int points = 0;
                foreach (var contestPasswordPoints in user.Value)
                {
                    points += contestPasswordPoints.Value;
                }
                if (bestPoints < points)
                {
                    bestPoints = points;
                    bestCandidate = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
            Console.WriteLine($"Ranking: ");

            usernameContestPasswordPoints = usernameContestPasswordPoints
               .OrderBy(x => x.Key)
               .ToDictionary(x => x.Key, y => y.Value);

            foreach (var contestPasswordPoints in usernameContestPasswordPoints)
            {
                Console.WriteLine(contestPasswordPoints.Key);

                var printPoints = contestPasswordPoints
                      .Value
                      .OrderByDescending(x => x.Value)
                      .ToDictionary(x => x.Key, y => y.Value);

                foreach (var points in printPoints)
                {
                    int index = points.Key.IndexOf(":");
                    Console.WriteLine($"#  {points.Key.Remove(index)} -> {points.Value}");
                }
            }
        }
    }
}
