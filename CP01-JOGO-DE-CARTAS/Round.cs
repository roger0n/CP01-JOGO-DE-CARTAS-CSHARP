using System.Collections.Generic;

namespace CardGameLib
{
    public class Round<TSuit, TRank>
    {
        public int Number { get; }
        public Dictionary<Player<TSuit, TRank>, Card<TSuit, TRank>> Plays { get; }

        public Round(int number)
        {
            Number = number;
            Plays = new Dictionary<Player<TSuit, TRank>, Card<TSuit, TRank>>();
        }

        public void PlayCard(Player<TSuit, TRank> player, Card<TSuit, TRank> card)
        {
            Plays[player] = card;
            player.Hand.RemoveCard(card);
        }
    }
}