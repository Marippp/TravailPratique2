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
            battlefieldDisplay.CardClicked += BattlefieldDisplay_CardClicked;
            controller.manaPoolUpdated += Controller_manaPoolUpdated;
        }

        private void Controller_manaPoolUpdated(object? sender, MTGO_lite.Models.Manas.Mana manaPool)
        {
            manaPoolDisplay.ManaPool = manaPool;
        }

        private void BattlefieldDisplay_CardClicked(object? sender, Card card)
        {
            try
            {
                controller.TapCard(card);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandDisplay_CardClicked(object? sender, Card card)
        {
            controller.PlayCard(card);
        }
    }
}