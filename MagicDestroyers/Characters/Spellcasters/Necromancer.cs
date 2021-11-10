using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enumerations;
using System;

public class Necromancer : Spellcaster
{
    //default character values
    private const string DEFAULT_NAME = "NBob";
    private const Faction DEFAULT_FACTION = Faction.Spellcaster;

    private const int DEFAULT_LEVEL = 1;
    private const int DEFAULT_MANA_POINTS = 20;
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

    public Necromancer()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    public Necromancer(string name, int level)
        : this(name, level, DEFAULT_HEALTH_POINTS)
    {
    }

    public Necromancer(string name, int level, int healthPoints)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoints = healthPoints;
        this.Faction = DEFAULT_FACTION;
        this.ManaPoints = DEFAULT_MANA_POINTS;
        this.BodyArmor = DEFAULT_ARMOR;
        this.Weapon = DEFAULT_WEAPON;
    }

    public void ShadowRage()
    {
        throw new NotImplementedException();
    }

    public void VampireTouch()
    {
        throw new NotImplementedException();
    }

    public void BoneShield()
    {
        throw new NotImplementedException();
    }
}
