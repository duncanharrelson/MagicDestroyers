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
            public const string NAME = "Large Bob";
            public const Faction FACTION = Faction.Melee;
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
        }

        public static class Knight
        {
            public const string NAME = "Valor Bob";
            public const Faction FACTION = Faction.Melee;
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
        }

        public static class Assassin
        {
            public const string NAME = "StabbyBob";
            public const Faction FACTION = Faction.Melee;
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
        }

        public static class Mage
        {
            public const string NAME = "Magic Bob";
            public const Faction FACTION = Faction.Spellcaster;
            public const int LEVEL = 1;
            public const int MANA_POINTS = 20;
            public const int HEALTH_POINTS = 100;
        }

        public static class Necromancer
        {
            public const string NAME = "Spooky Bob";
            public const Faction FACTION = Faction.Spellcaster;
            public const int LEVEL = 1;
            public const int MANA_POINTS = 20;
            public const int HEALTH_POINTS = 100;
        }

        public static class Druid
        {
            public const string NAME = "Tree Bob";
            public const Faction FACTION = Faction.Spellcaster;
            public const int LEVEL = 1;
            public const int MANA_POINTS = 20;
            public const int HEALTH_POINTS = 100;
        }

    }
}
