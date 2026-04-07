namespace CardGameLib
{
    public class Card<TSuit, TRank>
    {
        public TSuit Suit { get; }
        public TRank Rank { get; }

        public Card(TSuit suit, TRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}