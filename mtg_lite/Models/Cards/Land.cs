using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Land : Card
    {
        public Land(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        static public Land FabriquerCarteLand(string name)
        {   
            switch (name)
            {
                case "swamp":
                    return new Land("swamp", new Mana(0, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resource/swamp.png")));
                    
                case "island":
                    return new Land("island", new Mana(0, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resource/island.png")));
                    
                case "mountain":
                    return new Land("mountain", new Mana(0, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resource/mountain.png")));
                case "forest":
                    return new Land("mountain", new Mana(0, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resource/forest.png")));
                default:
                    return new Land("swamp", new Mana(0, 0, 0, 0, 0, 0), new Bitmap(Image.FromFile("Resource/swamp.png")));

            }
        }
    }
}
