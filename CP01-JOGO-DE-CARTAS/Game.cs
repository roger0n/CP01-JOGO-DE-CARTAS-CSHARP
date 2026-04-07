using System.Collections.Generic;

namespace CardGameLib
{
    public class Game<TSuit, TRank>
    {
        public List<Player<TSuit, TRank>> Players { get; }
        public Deck<TSuit, TRank> Deck { get; }
        public List<Round<TSuit, TRank>> Rounds { get; }

        private int _roundCounter = 0;

        public Game(List<Player<TSuit, TRank>> players, Deck<TSuit, TRank> deck)
        {
            Players = players;
            Deck = deck;
            Rounds = new List<Round<TSuit, TRank>>();
        }

        public Round<TSuit, TRank> StartNewRound()
        {
            var round = new Round<TSuit, TRank>(++_roundCounter);
            Rounds.Add(round);
            return round;
        }
    }
}
