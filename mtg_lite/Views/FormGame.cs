using mtg_lite.Controllers;
using mtg_lite.Models.Cards;

namespace mtg_lite
{
    public partial class FormGame : Form
    {
        private Controller controller;

        public FormGame()
        {
            InitializeComponent();
            controller = new Controller();
            InitZonesDisplay();
            manaPoolDisplay.ManaPool = controller.Player.ManaPool;
            Subscribe();
        }

        private void InitZonesDisplay()
        {
            libraryDisplay.Zone = controller.Player.Library;
            graveyardDisplay.Zone = controller.Player.Graveyard;
            graveyardDisplay.DesactiverClick();
            handDisplay.Hand = controller.Player.Hand;
            battlefieldDisplay.Battlefield = controller.Player.Battlefield;
        }

        private void libraryDisplay_Click(object sender, EventArgs e)
        {
            controller.DrawCard();
        }
        private void Subscribe()
        {
            handDisplay.CardClicked += HandDisplay_CardClicked;
        }

        private void HandDisplay_CardClicked(object? sender, Card card)
        {
            controller.PlayCard(card);
        }
    }
}