using System;
using System.Collections.Generic;
using System.Linq;

using Poker2.Resources.Models;

namespace Poker2.Resources.Helpers
{
    public class BlindsHelper
    {
        private const int startingChips = 5000;
        public readonly Blind[]
            Blinds;

        public BlindsHelper()
        {
            Blinds = new Blind[22];
            Blinds[0] = new Blind(25, 50);
            Blinds[1] = new Blind(50, 100);
            Blinds[2] = new Blind(75, 150);
            Blinds[3] = new Blind(100, 200);
            Blinds[4] = new Blind(150, 300);
            Blinds[5] = new Blind(200, 400);
            Blinds[6] = new Blind(300, 600);
            Blinds[7] = new Blind(400, 800);
            Blinds[8] = new Blind(500, 1000);
            Blinds[9] = new Blind(600, 1200);
            Blinds[10] = new Blind(800, 1600);
            Blinds[11] = new Blind(1000, 2000);
            Blinds[12] = new Blind(1200, 2400);
            Blinds[13] = new Blind(1500, 3000);
            Blinds[14] = new Blind(2000, 4000);
            Blinds[15] = new Blind(2500, 5000);
            Blinds[16] = new Blind(3000, 6000);
            Blinds[17] = new Blind(4000, 8000);
            Blinds[18] = new Blind(5000, 10000);
            Blinds[19] = new Blind(6000, 12000);
            Blinds[20] = new Blind(8000, 16000);
            Blinds[21] = new Blind(10000, 20000);
        }
        
        public int GetBlindTimeInMS(double hours, double numberOfPlayers)
        {
            var hoursToMS = hours*60*60*1000;
            var ms = Convert.ToInt32(hoursToMS);

            var firstResult = (numberOfPlayers * startingChips) / 10;
            var maxBBindex = GetBlindClosestTotheSum(firstResult);
            var time = ms / maxBBindex;

            return time;
        }

        public int GetBlindClosestTotheSum(double sum)
        {
            var minDistance = double.MaxValue;
            var index = -1;
            for (int i = 0; i < Blinds.Length; i++)
            {
                var tmp = Math.Abs(Blinds[i].BigBlind - sum);
                if (tmp < minDistance)
                {
                    minDistance = tmp;
                    index = i;
                }
            }

            return index;
        }

    }
}