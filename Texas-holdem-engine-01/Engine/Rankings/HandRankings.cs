namespace Engine.Rankings
{
    public static class HandRankings
    {
        public static int RoyalFlush => 200;
        public static int StraightFlush => 180;
        public static int FourOfAKind => 160;
        public static int FullHouse => 140;
        public static int Flush => 120;
        public static int Straight => 100;
        public static int ThreeOfKind => 80;
        public static int TwoPair => 60;
        public static int Pair => 40;
        public static int HighCard { get; set; }
    }
}
