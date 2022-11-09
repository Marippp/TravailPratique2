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
        }

        //Faire une fonction pour mettre DarkCardBack si la pile est vide sinon mettre l'autre
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
        public Card GetTopCard()
        {
            return cards[cards.Count - 1];
        }
        public void MixCards()
        {
            //Mettre du code pour brasser les cartes
            List<int> PositionHasard = new List<int>();
            List<Card> cardsTemp = LibraryManager.GetCards("deck");
            //Faire un random et compter les carte avec count
        }
        public void RemoveCardsFromLibrary()
        {

        }
    }
}
