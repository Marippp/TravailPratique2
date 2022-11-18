using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using mtg_lite.Models.Zones;
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
                    player.Battlefield.AddCard(card);
                }
                else
                {
                    if (player.ManaPool >= card.ManaCost)
                    {
                        switch (card)
                        {
                            case Sorcery:
                                player.ManaPool.Pay(card.ManaCost);
                                player.Graveyard.AddCard(card);
                                break;
                            case Creature:
                                player.ManaPool.Pay(card.ManaCost);
                                player.Battlefield.AddCard(card);
                                break;
                            default:
                                player.Battlefield.AddCard(card);
                                break; ;
                        }
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
