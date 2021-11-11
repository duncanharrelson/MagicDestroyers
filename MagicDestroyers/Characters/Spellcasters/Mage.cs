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
    }

    public override void BasicAttack()
    {
        this.ArcaneWrath();
    }

    public override void SpecialAttack()
    {
        this.Fireball();
    }

    public override void Defend()
    {
        this.Meditation();
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
