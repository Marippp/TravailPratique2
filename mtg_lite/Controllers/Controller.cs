using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using mtg_lite.Models.Zones;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Controllers
{
    public class Controller
    {
        private Player player;

        public event EventHandler<Mana> manaPoolUpdated;

        public Player Player { get => player; }

        public Controller()
        {
            player = new Player("deck");
        }

        public void PlayCard(Card card)
        {
            try
            {
                if (card.GetType() == typeof(Land))
                {
                    player.Hand.RemoveCard(card);
                }
                else
                {
                    if ((player.ManaPool >= card.ManaCost) || card.EstPermanent())
                    {
                        player.Hand.RemoveCard(card);
                    }
                    else
                    {
                        throw new Exception("Vous n'avez pas assez de mana pour jouer cette carte.");
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void TapCard(Card card)
        {
            if (card.GetType() == typeof(Land))
            {
                card.Tapped = !card.Tapped;
                if (card.Tapped)
                {
                    player.ManaPool.Add(card.ManaCost);
                    manaPoolUpdated?.Invoke(this, player.ManaPool);
                }
            }
            else
            {
                if (!card.Tapped)
                {
                    if (player.ManaPool >= card.ManaCost)
                    {
                        player.ManaPool.Pay(card.ManaCost);
                        card.Tapped = !card.Tapped;
                        manaPoolUpdated?.Invoke(this, player.ManaPool);
                    }
                    else
                    {
                        throw new Exception("Vous n'avez pas assez de mana pour jouer cette carte.");
                    }
                }
                else
                {
                    card.Tapped = false;
                }
            }
        }


        public void DrawCard()
        {
            try
            {
                if (player.Library.Cards.Count > 0)
                {
                    player.Library.RemoveCard(player.Library.Cards[0]);
                }
                else
                {
                    throw new Exception("La pioche est vide, vous avez utilisé toutes les cartes.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
    }
}
