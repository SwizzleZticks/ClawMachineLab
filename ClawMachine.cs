using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClawMachineLab
{
    public static class ClawMachine
    {
        private static Random rnd = new Random();
        public static List<Reward> Rewards { get; } = new List<Reward>
        {
            new Reward("Cheap candy", 0.50m),
            new Reward("Cheap candy", 0.50m),
            new Reward("Cheap candy", 0.50m),
            new Reward("Candy Bar", 1.00m),
            new Reward("Candy Bar", 1.00m),
            new Reward("Stuffed Animal", 10.00m)
        };

        public static decimal CostToPlay { get; } = 1.50m;

        public static Reward GetReward()
        {
            return Rewards[rnd.Next(0,Rewards.Count)];
        }

        public static bool MadeProfit(Reward aReward)
        {
            return aReward.Value > CostToPlay;
        }

        public static void Play()
        {
            Reward aReward = GetReward();
            Console.WriteLine($"Reward: {aReward.Name}");
            bool isProfitable = MadeProfit(aReward);

            if (isProfitable)
            {
                Console.WriteLine("You made a profit.");
            }
            else
            {
                Console.WriteLine("You lost money.");
            }
        }
    }
}
