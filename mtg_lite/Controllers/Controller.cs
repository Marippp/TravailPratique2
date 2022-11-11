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
            player = new Player("Red");
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

                MessageBox.Show(ex.Message);
            }
        }

        public void DrawCard()
        {
            try
            {
                if (player.Library.Cards.Count > 0)
                {
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
