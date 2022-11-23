using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Hand : Zone
    {
        public new string Name { get => "Hand"; }
        public Hand(List<Card> cards, Player player) : base(cards, player)
        {
            Subscribe();
        }
        public void Subscribe()
        {
            CardAdded += Hand_CardAdded;
        }
        private void Hand_CardAdded(object? sender, Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public override string ToString()
        {
            return $"{Name} ({cards.Count})";
        }
    }
}
