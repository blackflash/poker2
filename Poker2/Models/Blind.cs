using System;

namespace Poker2.Models
{
    [Serializable]
    public class Blind
    {
        public int SmallBlind;
        public int BigBlind;
        public int MSLeft;

        public Blind(int smallBlind, int bigBlind)
        {
            SmallBlind = smallBlind;
            BigBlind = bigBlind;
        }
    }
}