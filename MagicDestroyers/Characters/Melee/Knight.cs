using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Knight : Melee
{
    //default character values
    private const string DEFAULT_NAME = "KBob";
    private const Faction DEFAULT_FACTION = Faction.Melee;

    private const int DEFAULT_LEVEL = 1;
    private const int DEFAULT_ABILITY_POINTS = 10;
    private const int DEFAULT_HEALTH_POINTS = 100;

    private readonly ChainLink DEFAULT_ARMOR = new ChainLink();
    private readonly Hammer DEFAULT_WEAPON = new Hammer();

    private Hammer weapon;
    private ChainLink bodyArmor;

    public Hammer Weapon
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
    
    public Knight()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    public Knight(string name, int level)
        : this(name, level, DEFAULT_HEALTH_POINTS)
    {
    }

    public Knight(string name, int level, int healthPoints)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoints = healthPoints;
        this.Faction = DEFAULT_FACTION;
        this.AbilityPoints = DEFAULT_ABILITY_POINTS;
        this.BodyArmor = DEFAULT_ARMOR;
        this.Weapon = DEFAULT_WEAPON;
    }

    public void HolyBlow()
    {
        throw new NotImplementedException();
    }

    public void PurifySoul()
    {
        throw new NotImplementedException();
    }

    public void RighteousWings()
    {
        throw new NotImplementedException();
    }
}

