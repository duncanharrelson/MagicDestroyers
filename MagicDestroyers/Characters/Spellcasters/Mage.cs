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
         

    public Mage()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    public Mage(string name, int level)
        : this(name, level, DEFAULT_MANA_POINTS)
    {
    }

    public Mage(string name, int level, int manaPoints)
        : base(name, level, manaPoints)
    {
        base.HealthPoints = DEFAULT_HEALTH_POINTS;
        base.Faction = DEFAULT_FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
        base.IsAlive = true;
        base.Scores = 0;
    }

    public override int BasicAttack()
    {
        return this.Fireball();
    }

    public override int SpecialAttack()
    {
        return this.ArcaneWrath();
    }

    public override int Defend()
    {
        return this.Meditation();
    }

    public int Fireball()
    {
        return base.Weapon.Damage + 10;
    }

    public int ArcaneWrath()
    {
        throw new NotImplementedException();
    }


    public int Meditation()
    {
        return base.BodyArmor.ArmorPoints + 5;
    }
}
