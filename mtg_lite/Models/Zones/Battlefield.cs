using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Battlefield : Zone
    {
        public new string Name { get => "Battlefield"; }
        public Battlefield(List<Card> cards, Player player) : base(cards, player)
        {
            Subscribe();
        }
        public void Subscribe()
        {
            CardAdded += Battlefield_CardAdded;
        }
        public void Unsubscribe()
        {
            CardRemoved += Battlefield_CardRemoved;
        }

        private void Battlefield_CardAdded(object? sender, Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        private void Battlefield_CardRemoved(object? sender, Card cardToRemove)
        {
            cards.Remove(cardToRemove);
        }

        public void ChangeTapped(Card card) 
        {
            switch (card)
            {
                case Land:
                    card.Tapped = true;
                    player.ManaPool.Add(card.ManaCost);
                    break;
                case Creature:
                    card.Tapped = true;
                    break;
                default:
                    break;
            }
        }
    }
}
