using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Creature : Card
    {
        public Creature(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {

        }

        static public Creature FabriquerCarteCreature(string name)
        {
            switch (name)
            {
                case "aegis_turtle":
                    return new Creature("aegis_turtle", new Mana(0,1,0,0,0,0), Resource.aegis_turtle);
                case "barony_vampire":
                    return new Creature("barony_vampire", new Mana(1, 0, 0, 0, 0, 2), Resource.barony_vampire);
                case "scathe_zombies":
                    return new Creature("scathe_zombies", new Mana(1, 0, 0, 0, 0, 2), Resource.scathe_zombies);
                default:
                    return new Creature("scathe_zombies", new Mana(1, 0, 0, 0, 0, 2), Resource.scathe_zombies);
            }
        }

        public override bool EstPermanent()
        {
            return true;
        }
    }
}
