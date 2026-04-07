using System.Collections.Generic;

namespace CardGameLib
{
    public class Hand<TSuit, TRank>
    {
        private readonly List<Card<TSuit, TRank>> _cards = new();

        public IReadOnlyList<Card<TSuit, TRank>> Cards => _cards;

        public void AddCard(Card<TSuit, TRank> card)
        {
            _cards.Add(card);
        }

        public void RemoveCard(Card<TSuit, TRank> card)
        {
            _cards.Remove(card);
        }
    }
}