namespace Poker2.Resources.Models
{
    public class Blind
    {
        public int SmallBlind;
        public int BigBlind;

        public Blind(int smallBlind, int bigBlind)
        {
            SmallBlind = smallBlind;
            BigBlind = bigBlind;
        }
    }
}