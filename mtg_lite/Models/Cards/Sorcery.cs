using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Sorcery : Card
    {
        public Sorcery(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {

        }
        static public Sorcery FabriquerCarteSorcery(string name)
        {
            switch (name)
            {
                case "incriminate":
                    return new Sorcery("incriminate", new Mana(1, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resources/incriminate.png")));
                case "glimpse_the_unthinkable":
                    return new Sorcery("glimpse_the_unthinkable", new Mana(1, 1, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resources/glimpse_the_unthinkable.png")));
                case "blightning":
                    return new Sorcery("blightning", new Mana(1, 0, 0, 1, 0, 0), new Bitmap(Image.FromFile("Resources/blightning")));
                default:
                    return new Sorcery("incriminate", new Mana(1, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resources/incriminate.png")));
            }
        }
    }
}
