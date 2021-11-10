using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enumerations;
using System;

public class Mage : Spellcaster
{
    //default character values
    private const string DEFAULT_NAME = "MBob";
    private const Faction DEFAULT_FACTION = Faction.Spellcaster;

    private const int DEFAULT_LEVEL = 1;
    private const int DEFAULT_MANA_POINTS = 20;
    private const int DEFAULT_HEALTH_POINTS = 100;

    private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
    private readonly Staff DEFAULT_WEAPON = new Staff();



    private Staff weapon;
    private ClothRobe bodyArmor;

    public Staff Weapon
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
    public ClothRobe BodyArmor
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

    public Mage()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    public Mage(string name, int level)
        : this(name, level, DEFAULT_HEALTH_POINTS)
    {
    }

    public Mage(string name, int level, int healthPoints)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoints = healthPoints;
        this.Faction = DEFAULT_FACTION;
        this.ManaPoints = DEFAULT_MANA_POINTS;
        this.BodyArmor = DEFAULT_ARMOR;
        this.Weapon = DEFAULT_WEAPON;
    }

    public void ArcaneWrath()
    {
        throw new NotImplementedException();
    }

    public void Fireball()
    {
        throw new NotImplementedException();
    }

    public void Meditation()
    {
        throw new NotImplementedException();
    }
}
