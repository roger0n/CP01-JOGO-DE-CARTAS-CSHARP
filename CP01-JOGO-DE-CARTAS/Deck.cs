using System;
using System.Collections.Generic;

namespace CardGameLib
{
    public class Deck<TSuit, TRank>
    {
        private readonly Stack<Card<TSuit, TRank>> _cards;

        public Deck(IEnumerable<Card<TSuit, TRank>> cards)
        {
            _cards = new Stack<Card<TSuit, TRank>>(cards);
        }

        public int Count => _cards.Count;

        public Card<TSuit, TRank> Draw()
        {
            return _cards.Pop();
        }

        public void Shuffle()
        {
            var random = new Random();
            var list = new List<Card<TSuit, TRank>>(_cards);

            _cards.Clear();

            while (list.Count > 0)
            {
                int index = random.Next(list.Count);
                _cards.Push(list[index]);
                list.RemoveAt(index);
            }
        }
    }
}