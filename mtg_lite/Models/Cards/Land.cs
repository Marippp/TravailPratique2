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
        public bool tapped;


        public Land(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        public bool Tapped { get => tapped;}

        static public Land FabriquerCarteLand(string name)
        {   
            switch (name)
            {
                case "swamp":
                    return new Land("swamp", new Mana(0, 0, 0, 0, 0, 0),Resource.swamp);
                    
                case "island":
                    return new Land("island", new Mana(0, 0, 0, 0, 0, 0), Resource.island);
                    
                case "mountain":
                    return new Land("mountain", new Mana(0, 0, 0, 0, 0, 0), Resource.mountain);
                case "forest":
                    return new Land("mountain", new Mana(0, 0, 0, 0, 0, 0), Resource.forest);
                default:
                    return new Land("swamp", new Mana(0, 0, 0, 0, 0, 0), Resource.swamp);

            }
        }
    }
}
