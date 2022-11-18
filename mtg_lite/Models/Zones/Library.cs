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
    public class Library : Zone
    {
        public new string Name { get => "Library"; }
        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            MixCards();
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
        private Card GetTopCard()
        {
            return cards[cards.Count - 1];
        }
        private void MixCards()
        {
            Card[] cardsTemp = new Card[cards.Count()];
            Random random = new();
            
            for (int index = 0; index < cardsTemp.Count(); index++)
            {
                int randomPosition = random.Next(cards.Count());
                cardsTemp[index] = cards[randomPosition];
                cards.Remove(cards[randomPosition]);
            }

            foreach (var carte in cardsTemp)
            {
                cards.Add(carte);
            }
        }
    }
}
