using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armors
{
    public class Armor
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.armorPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value!  Must be between 1 and 100!");
                }
            }
        }
    }
}
