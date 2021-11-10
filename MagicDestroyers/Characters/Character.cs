using MagicDestroyers.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        private Faction faction;
        private string name;

        
        
        private int healthPoints;
        private int level;

        


        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "No name";
                    Console.WriteLine("Name must be between 2 and 10 characters in length.");
                }

            }
        }

     
        
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    this.healthPoints = 100;
                    Console.WriteLine("Health cannot be negative or greater than 120!");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Level must be between 1 and 100!  Level set to 1.");
                    this.level = 1;
                }
            }
        }

        public Character(int level)
        {
        
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            
        }
    }
}
