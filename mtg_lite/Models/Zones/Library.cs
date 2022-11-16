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

        public new Card TopCard
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
            Card[] cardsTemp = new Card[cards.Count];
            Random random = new();
            int position = 0;

            while (position < cards.Count)
            {
                int positionTemp = random.Next(0, cards.Count - 1);

                if (cardsTemp[positionTemp] == null)
                {
                    cardsTemp[positionTemp] = cards[position];
                    position++;
                }
            }
            cards = null;
            foreach (var carte in cardsTemp)
            {
                cards.Add(carte);
            }
        }
        public Card RemoveCardsFromLibrary()
        {
            Card cardToRemove = GetTopCard();
            if (cardToRemove == null)
            {
                throw new Exception("La pioche est vide, vous avez utiliser toutes les cartes.");
            }
            RemoveCard(cardToRemove);
            return cardToRemove;
        }
    }
}
