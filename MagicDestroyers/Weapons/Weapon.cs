using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Weapons
{
    public abstract class Weapon
    {
        private int damage;
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.damage = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!  Must be between 1 and 100!");
                }

            }
        }
    }
}
