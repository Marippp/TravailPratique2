using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using MTGO_lite.Models.Manas.ManaColors;

namespace MTGO_lite.Models.Manas
{
    public class Mana
    {
        private Dictionary<string, ManaColor> manaColors;

        public ManaColor White
        {
            get => manaColors[ManaWhite.Name];
        }
        public ManaColor Blue
        {
            get => manaColors[ManaBlue.Name];
        }
        public ManaColor Black
        {
            get => manaColors[ManaBlack.Name];
        }
        public ManaColor Red
        {
            get => manaColors[ManaRed.Name];
        }
        public ManaColor Green
        {
            get => manaColors[ManaGreen.Name];
        }
        public ManaColor Colorless
        {
            get => manaColors[ManaColorless.Name];
        }
        public Dictionary<string, ManaColor> ManaColors { get => manaColors; }

        public Mana(): this(0, 0, 0, 0, 0, 0)
        {
        }

        public Mana(int black, int blue, int green, int red, int white, int colorless)
        {
            manaColors = new Dictionary<string, ManaColor>()
            {
                { ManaBlack.Name, new ManaBlack(black)},
                { ManaBlue.Name, new ManaBlue(blue)},
                { ManaGreen.Name, new ManaGreen(green)},
                { ManaRed.Name, new ManaRed(red)},
                { ManaWhite.Name, new ManaWhite(white)},
                { ManaColorless.Name, new ManaColorless(colorless)},
            };
        }

        public void Pay(Mana manaToPay)
        {
            manaColors[ManaBlack.Name].Remove(manaToPay.Black);
            manaColors[ManaBlue.Name].Remove(manaToPay.Blue);
            manaColors[ManaGreen.Name].Remove(manaToPay.Green);
            manaColors[ManaRed.Name].Remove(manaToPay.Red);
            manaColors[ManaWhite.Name].Remove(manaToPay.White);

            CompterColorless();
        }
        public void CompterColorless()
        {
            manaColors[ManaColorless.Name].Remove(manaColors[ManaColorless.Name]);

            manaColors[ManaColorless.Name].Add(manaColors[ManaBlack.Name]);
            manaColors[ManaColorless.Name].Add(manaColors[ManaBlue.Name]);
            manaColors[ManaColorless.Name].Add(manaColors[ManaGreen.Name]);
            manaColors[ManaColorless.Name].Add(manaColors[ManaRed.Name]);
            manaColors[ManaColorless.Name].Add(manaColors[ManaWhite.Name]);

        }

        //trouver moyen de reset et de compter le colorless a chaque fois et de remplacer nbColorless dans l operateur

        public void Add(Mana mana)
        {
            foreach (var manaColor in mana.manaColors)
            {
                manaColors[manaColor.Key].Add(manaColor.Value);
             
            }
        }

        public static bool operator >=(Mana mana1, Mana mana2) 
        {
            int nbColorLess = mana1.ManaColors[ManaColorless.Name].Quantity - mana2.ManaColors[ManaBlack.Name].Quantity - mana2.ManaColors[ManaBlue.Name].Quantity - mana2.ManaColors[ManaGreen.Name].Quantity - mana2.ManaColors[ManaRed.Name].Quantity - mana2.ManaColors[ManaWhite.Name].Quantity;

            if (mana1.ManaColors[ManaBlack.Name].Quantity >= mana2.ManaColors[ManaBlack.Name].Quantity)
            {
                if (mana1.ManaColors[ManaBlue.Name].Quantity >= mana2.ManaColors[ManaBlue.Name].Quantity)
                {
                    if (mana1.ManaColors[ManaGreen.Name].Quantity >= mana2.ManaColors[ManaGreen.Name].Quantity)
                    {
                        if (mana1.ManaColors[ManaRed.Name].Quantity >= mana2.ManaColors[ManaRed.Name].Quantity)
                        {
                            if (mana1.ManaColors[ManaWhite.Name].Quantity >= mana2.ManaColors[ManaWhite.Name].Quantity)
                            {
                                if (nbColorLess >= mana2.ManaColors[ManaColorless.Name].Quantity)
                                {
                                    return true;
                                }
                                return false;
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public static bool operator <=(Mana mana1, Mana mana2)
        {
            int nbColorLess = mana1.ManaColors[ManaColorless.Name].Quantity - mana2.ManaColors[ManaBlack.Name].Quantity - mana2.ManaColors[ManaBlue.Name].Quantity - mana2.ManaColors[ManaGreen.Name].Quantity - mana2.ManaColors[ManaRed.Name].Quantity - mana2.ManaColors[ManaWhite.Name].Quantity;

            if (mana1.ManaColors[ManaBlack.Name].Quantity <= mana2.ManaColors[ManaBlack.Name].Quantity)
            {
                if (mana1.ManaColors[ManaBlue.Name].Quantity <= mana2.ManaColors[ManaBlue.Name].Quantity)
                {
                    if (mana1.ManaColors[ManaGreen.Name].Quantity <= mana2.ManaColors[ManaGreen.Name].Quantity)
                    {
                        if (mana1.ManaColors[ManaRed.Name].Quantity <= mana2.ManaColors[ManaRed.Name].Quantity)
                        {
                            if (mana1.ManaColors[ManaWhite.Name].Quantity <= mana2.ManaColors[ManaWhite.Name].Quantity)
                            {
                                if (nbColorLess <= mana2.ManaColors[ManaColorless.Name].Quantity)
                                {
                                    return true;
                                }
                                return false;
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;

            }
            return false;
        }

    }
}
