using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Warrior : Melee
{
    //default character values
    private const string DEFAULT_NAME = "Bob";
    private const Faction DEFAULT_FACTION = Faction.Melee;

    private const int DEFAULT_LEVEL = 1;
    private const int DEFAULT_ABILITY_POINTS = 10;
    private const int DEFAULT_HEALTH_POINTS = 100;

    private readonly ChainLink DEFAULT_ARMOR = new ChainLink();
    private readonly Axe DEFAULT_WEAPON = new Axe();

    private Axe weapon;
    private ChainLink bodyArmor;

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

    //basic class constructor with no input
    public Warrior()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {        
    }

    //Chained constructor inputs values above for name and level arguments
    public Warrior(string name, int level)
        : this(name, level, DEFAULT_ABILITY_POINTS)
    {
    }

    public Warrior(string name, int level, int abilityPoints)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoints = DEFAULT_HEALTH_POINTS;
        this.Faction = DEFAULT_FACTION;
        this.AbilityPoints = abilityPoints;
        this.BodyArmor = DEFAULT_ARMOR;
        this.Weapon = DEFAULT_WEAPON;
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

