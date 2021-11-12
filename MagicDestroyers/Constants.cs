using MagicDestroyers.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
    public static class Constants
    {
        public static class Warrior
        {
            public const string NAME = "Bob";
            public const Faction FACTION = Faction.Melee;
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
        }
        
        public static class Mage
        {
            public const string NAME = "MBob";
            public const Faction FACTION = Faction.Spellcaster;
            public const int LEVEL = 1;
            public const int MANA_POINTS = 20;
            public const int HEALTH_POINTS = 100;
        }


        
    }
}
