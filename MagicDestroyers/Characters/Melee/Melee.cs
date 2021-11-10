using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 10;
                    Console.WriteLine("Ability points cannot be negative or greater than 10!");
                }

            }
        }
        public Melee(string name, int level, int abilityPoints)
            :base(name, level)
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
        }

    }
}
