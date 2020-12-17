namespace Engine.Models
{
    public class CheckEqualRanksResult
    {
        public int PairCount { get; set; }
        public int PairValue { get; set; }
        public bool ThreeOfKind { get; set; }
        public int ThreeOfKindValue { get; set; }
        public bool FourOfKind { get; set; }
        public int FourOfKindValue { get; set; }
        public bool FullHouse { get; set; }
        public int FullHouseValue { get; set; }
    }
}
