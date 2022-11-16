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
        public void Unsubscribe()
        {
            CardRemoved -= Hand_CardRemoved;
        }
        private void Hand_CardAdded(object? sender, Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        private void Hand_CardRemoved(object? sender, Card cardToRemove)
        {
            cards.Remove(cardToRemove);
        }
    }
}
