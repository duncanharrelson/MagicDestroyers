using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {

        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.manaPoints = value;
                }
                else
                {
                    this.manaPoints = 20;
                    Console.WriteLine("Ability points cannot be negative or greater than 20!");
                }
            }
        }

        public Spellcaster(string name, int level, int manaPoints)
            :base(name, level)
        {
            this.Name = name;
            this.Level = level;
            this.ManaPoints = manaPoints;
        }
    }    
}
