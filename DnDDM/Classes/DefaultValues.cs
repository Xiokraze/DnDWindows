using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDDM.Classes
{
    public class DefaultValues
    {
        public static string DnDTitle = "DnDDM";

        public static Color DnDBlack = ColorTranslator.FromHtml("#030303"); //3,3,3
        public static Color DnDDark = ColorTranslator.FromHtml("#290000"); //41,0,0
        public static Color DnDRed = ColorTranslator.FromHtml("#930C10"); //147,12,16
        public static Color DnDGold = ColorTranslator.FromHtml("#F7CE65"); //247,206,101
        public static Color DnDLight = ColorTranslator.FromHtml("#FFFEBD"); //255, 254, 189

        // Item Classifications.
        public static string Armor = "Armor";
        public static string Art = "Art";
        public static string Gem = "Gem";
        public static string Good = "Good";
        public static string Trinket = "Trinket";
        public static string Weapon = "Weapon";

        // Gold Values.
        public static string gp10 = "10 gp";
        public static string gp25 = "25 gp";
        public static string gp50 = "50 gp";
        public static string gp100 = "100 gp";
        public static string gp250 = "250 gp";
        public static string gp500 = "500 gp";
        public static string gp750 = "750 gp";
        public static string gp1000 = "1000 gp";
        public static string gp2500 = "2500 gp";
        public static string gp5000 = "5000 gp";
        public static string gp7500 = "7500 gp";

        // Goods.
        public static string ammunition = "Ammunition";
        public static string arcaneFocus = "Arcane Focus";
        public static string druidicFocus = "Druidic Focus";
        public static string good = "General Good";
        public static string holySymbol = "Holy Symbol";

        // Weapons.
        public static string simpleMelee = "Simple Melee";
        public static string simpleRanged = "Simple Ranged";
        public static string martialMelee = "Martial Melee";
        public static string martialRanged = "Martial Ranged";

        //Armor.
        public static string lightAmor = "Light Armor";
        public static string mediumAmor = "Medium Armor";
        public static string heavyAmor = "Heavy Armor";
        public static string shields = "Shields";

    }
}
