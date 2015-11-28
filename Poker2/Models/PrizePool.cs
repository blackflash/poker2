using System;
using System.Collections.Generic;

namespace Poker2.Models
{
    [Serializable]
    public class Prize
    {
        public int Percentage;
        public int Place;
        public Prize(int place, int percentage)
        {
            Place = place;
            Percentage = percentage;
        }
    }

    [Serializable]
    public class PrizePool
    {
        public double SUM;
        public List<Prize> prices;
        public int minPlayers;
        public int maxPlayers;
    }

    public class Priezepools
    {
        public List<PrizePool> Prizeppols;
        public Priezepools()
        {
            Prizeppols = new List<PrizePool>();
            Prizeppols.Add(new PrizePool()
            {
                minPlayers = 2,
                maxPlayers = 3,
                prices = new List<Prize>()
                {
                    {new Prize(1,100)}
                }
            });
            Prizeppols.Add(new PrizePool()
            {
                minPlayers = 4,
                maxPlayers = 5,
                prices = new List<Prize>()
                {
                    {new Prize(1,75)},
                    {new Prize(2,25)}
                }
            });
            Prizeppols.Add(new PrizePool()
            {
                minPlayers = 6,
                maxPlayers = 10,
                prices = new List<Prize>()
                {
                    {new Prize(1,50)},
                    {new Prize(2,30)},
                    {new Prize(3,20)}
                }
            });
            Prizeppols.Add(new PrizePool()
            {
                minPlayers = 11,
                maxPlayers = 20,
                prices = new List<Prize>()
                {
                    {new Prize(1,50)},
                    {new Prize(2,25)},
                    {new Prize(3,15)},
                    {new Prize(4,10)}
                }
            });
            Prizeppols.Add(new PrizePool()
            {
                minPlayers = 21,
                maxPlayers = 40,
                prices = new List<Prize>()
                {
                    {new Prize(1,40)},
                    {new Prize(2,25)},
                    {new Prize(3,20)},
                    {new Prize(4,10)},
                    {new Prize(5,5)}
                }
            });
            Prizeppols.Add(new PrizePool()
            {
                minPlayers = 41,
                maxPlayers = 70,
                prices = new List<Prize>()
                {
                    {new Prize(1,40)},
                    {new Prize(2,20)},
                    {new Prize(3,14)},
                    {new Prize(4,10)},
                    {new Prize(5,7)},
                    {new Prize(6,5)},
                    {new Prize(7,4)}
                }
            });

        }
    }
}