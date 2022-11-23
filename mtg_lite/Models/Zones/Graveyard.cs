using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.CardBacks;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Graveyard : Zone
    {
        public new string Name { get => "Graveyard"; }
        public Graveyard(List<Card> cards, Player player) : base(cards, player)
        {
            subscribe();
        }

        public override Card TopCard
        {
            get
            {
                if (cards.Count == 0)
                {
                    return new DarkCardBack();
                }
                else
                {
                    return new CardBack();
                }
            }
        }

        private void subscribe()
        {
            CardAdded += Graveyard_CardAdded;
        }

        private void Graveyard_CardAdded(object? sender, Card card)
        {
            cards.Add(card);
        }

        public override string ToString()
        {
            return $"{Name} ({cards.Count})";
        }
    }
}
