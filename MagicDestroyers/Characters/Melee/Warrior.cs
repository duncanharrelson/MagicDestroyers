using System;

public class Warrior
{
    private string faction;
    private string name;

    private int abilityPoints;
    private int healthPoints;
    private int level;

    private ChainLink bodyArmor;
    private Axe weapon;

    public string Faction
    {
        get
        {
            return this.faction;
        }
        set
        {
            if(value == "Melee" || value == "Spellcaster")
            {
                this.faction = value;
            }
            else
            {
                this.faction = "Melee";
                Console.WriteLine("Please choose \"Melee\" or \"Spellcaster\"");
            }
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
            if (value.Length >=2 && value.Length <= 10)
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

    public int AbilityPoints
    {
        get
        {
            return this.abilityPoints;
        }
        set
        {
            if (value >= 0 && value < 10)
            {
                this.abilityPoints = value;
            }
            else
            {
                this.abilityPoints = 0;
                Console.WriteLine("Ability points cannot be negative or greater than 10!");
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
                this.healthPoints = level;
            }
            else
            {
                this.healthPoints = 1;
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
            if(value >= 1 && value <= 100)
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
    public ChainLink BodyArmor
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
    public Axe Weapon
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

    public Warrior()
        : this("Bob", 1)
    {        
    }

    public Warrior(string name, int level)
        : this(name, level, 10)
    {
    }

    public Warrior(string name, int level, int abilityPoints)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoints = 100;
        this.Faction = "Melee";
        this.AbilityPoints = abilityPoints;
        this.BodyArmor = new ChainLink();
        this.Weapon = new Axe();
    }

    public void Strike()
    {
        throw new NotImplementedException();
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }

    public void SkinHarden()
    {
        throw new NotImplementedException();
    }
}

