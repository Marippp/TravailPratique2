using mtg_lite.Models.Cards;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace mtg_lite.Models.Zones
{
    public static class LibraryManager
    {
        private static Dictionary<string, List<Card>> libraries = new Dictionary<string, List<Card>>()
        {
            {"deck", new List<Card>(
                Creature.FabriquerCarteCreature("aegis_turtle"),
                Creature.FabriquerCarteCreature("barony_vampire"),
                Creature.FabriquerCarteCreature("scathe_zombies"),
                Land.FabriquerCarteLand("swamp"),
                Land.FabriquerCarteLand("mountain"),
                Land.FabriquerCarteLand("forest"),
                Land.FabriquerCarteLand("island"),
                Sorcery.FabriquerCarteSorcery("incriminate"),
                Sorcery.FabriquerCarteSorcery("glimpse_the_unthinkable"),
                Sorcery.FabriquerCarteSorcery("blightning"))}
        };

        static LibraryManager()
        {
        }

        public static List<Card> GetCards(string libraryName)
        {
            if (libraries.ContainsKey(libraryName))
            {
                return libraries[libraryName];
            }
            return new List<Card>();
        }
    }
}
