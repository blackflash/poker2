using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Poker2.Helpers;

namespace Poker2.Models
{
    [Serializable]
    public class Game
    {
        public int NumberOfPlayers;
        public int SumOfChips;
        public double AvarageStack;
        public PrizePool PrizePool;
        public BlindsHelper BlindsHelper;
        public Blind CurrentBlind;
        public Blind[] Blinds;
        public int TimeperblindMS;


        public Game(double buyin, int numberOfPlayers, double numberOfHours)
        {
            var blindhelper = new BlindsHelper();
            TimeperblindMS = blindhelper.GetBlindTimeInMS(numberOfHours, numberOfPlayers);
            //var timeinMin = TimeperblindMS / 1000 / 60; 
            var prizePools = new Priezepools();
            PrizePool = prizePools.Prizeppols.FirstOrDefault(p => p.minPlayers <= numberOfPlayers && p.maxPlayers >= numberOfPlayers);
            if (PrizePool != null)
            {
                PrizePool.SUM = buyin * numberOfPlayers;
                AvarageStack = PrizePool.SUM / numberOfPlayers;
                Blinds = BlindsHelper.Blinds.Take(BlindsHelper.maxBBindex).ToArray();
                CurrentBlind = Blinds[0];
            }
        }


    }
}