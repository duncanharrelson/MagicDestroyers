using MagicDestroyers.Armors;
using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private string name;

        private int level;
        private int healthPoints;
        private int scores;
        
        private Faction faction;

        private Weapon weapon;
        private Armor bodyArmor;

        private bool isAlive;

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
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;

            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            protected set
            {
                this.isAlive = value;
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }
            protected set
            {
                this.scores = value;
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

        public abstract int BasicAttack();


        public abstract int SpecialAttack();
      

        public abstract int Defend();
        
        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Defense was too high!  No damage dealt!");
            } 

            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} received {damage} points of damage from {attackerName}, and has fallen!");
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} points of damage from {attackerName}, and has {this.healthPoints} health left!");
            }

        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }

    }
}
