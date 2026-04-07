using System;

namespace CardGameLib
{
    public class Player<TSuit, TRank>
    {
        public string Name { get; }
        public Hand<TSuit, TRank> Hand { get; }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand<TSuit, TRank>();
        }
    }
}