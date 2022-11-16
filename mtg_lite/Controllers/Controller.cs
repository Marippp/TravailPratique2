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
                if (player.ManaPool >= card.ManaCost)
                {
                    player.PlayCard(card);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Vous n'avez pas assez de mana pour jouer cette carte: " + ex.Message);
            }
        }

        public void DrawCard()
        {
            if (player.Library.Cards.Count > 0)
            {
                player.Library.RemoveCard(player.Library.TopCard);
            }
        }
        
    }
}
