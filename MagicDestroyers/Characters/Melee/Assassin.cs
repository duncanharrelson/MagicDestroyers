using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Assassin : Melee
{
    //default character values
    private const string DEFAULT_NAME = "ABob";
    private const Faction DEFAULT_FACTION = Faction.Melee;

    private const int DEFAULT_LEVEL = 1;
    private const int DEFAULT_ABILITY_POINTS = 10;
    private const int DEFAULT_HEALTH_POINTS = 100;

    private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
    private readonly Sword DEFAULT_WEAPON = new Sword();



    private LeatherVest bodyArmor;
    private Sword weapon;

    
    public LeatherVest BodyArmor
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
    public Sword Weapon
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

    public Assassin()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    public Assassin(string name, int level)
        : this(name, level, DEFAULT_HEALTH_POINTS)
    {
    }

    public Assassin(string name, int level, int abilityPoints)
        : base(name, level, abilityPoints)
    {
        base.HealthPoints = DEFAULT_HEALTH_POINTS;
        base.Faction = DEFAULT_FACTION;
        this.BodyArmor = DEFAULT_ARMOR;
        this.Weapon = DEFAULT_WEAPON;
    }

    public void Raze()
    {
        throw new NotImplementedException();
    }

    public void Bleed()
    {
        throw new NotImplementedException();
    }

    public void Survival()
    {
        throw new NotImplementedException();
    }
}