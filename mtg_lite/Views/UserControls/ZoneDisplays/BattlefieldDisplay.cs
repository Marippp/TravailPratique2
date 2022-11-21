using mtg_lite.Models.Cards;
using mtg_lite.Models.Zones;
using mtg_lite.Views.UserControls.CardDisplays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    public partial class BattlefieldDisplay : UserControl
    {
        private Zone? battlefield;

        public Zone? Battlefield { get => battlefield; set => ChangeBattlefield(value); }

        public BattlefieldDisplay()
        {
            InitializeComponent();
        }

        private void ChangeBattlefield(Zone? newBattlefield)
        {
            BattlefieldUnsubscribe();
            battlefield = newBattlefield;
            DisplayBattlefield();
            BattlefieldSubscribe();
        }

        private void DisplayBattlefield()
        {
            if (battlefield is null) { return; }
            grpBattlefield.Text = battlefield.ToString();
            List<Card> lstLands= new List<Card>();
            List<Card> lstCreatures = new List<Card>();
            foreach (Card card in battlefield.Cards)
            {
                if (card.GetType() == typeof(Land))
                {
                    lstLands.Add(card);
                }
                else
                {
                    lstCreatures.Add(card);
                }
            }
            landsDisplay.Cards = lstLands;
            creaturesDisplay.Cards = lstCreatures;
        }

        private void BattlefieldUnsubscribe()
        {
            if (battlefield is null) { return; }
            battlefield.CardsChanged -= Battlefield_CardsChanged;
            creaturesDisplay.CardClicked -= CreaturesDisplay_CardClicked;
            landsDisplay.CardClicked -= CreaturesDisplay_CardClicked;
        }

        private void BattlefieldSubscribe()
        {
            if (battlefield is null) { return; }
            battlefield.CardsChanged += Battlefield_CardsChanged;
            creaturesDisplay.CardClicked += CreaturesDisplay_CardClicked;
            landsDisplay.CardClicked += CreaturesDisplay_CardClicked;
        }

        private void CreaturesDisplay_CardClicked(object? sender, Card e)
        {
            // code pour relier au controlleur
        }

        private void Battlefield_CardsChanged(object? sender, List<Models.Cards.Card> cards)
        {
            DisplayBattlefield();
        }

        private void cardsDisplay_CardClicked(object sender, Models.Cards.Card card)
        {
            card.Picture.RotateFlip(RotateFlipType.Rotate180FlipY);
        }
    }
}
