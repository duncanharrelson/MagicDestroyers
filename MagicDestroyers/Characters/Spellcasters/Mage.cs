using MagicDestroyers;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enumerations;
using System;

public class Mage : Spellcaster
{
    private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
    private readonly Staff DEFAULT_WEAPON = new Staff();         

    public Mage()
        : this(Constants.Mage.NAME, Constants.Mage.LEVEL)
    {
    }

    public Mage(string name, int level)
        : this(name, level, Constants.Mage.MANA_POINTS)
    {
    }

    public Mage(string name, int level, int manaPoints)
        : base(name, level, manaPoints)
    {
        base.HealthPoints = Constants.Mage.HEALTH_POINTS;
        base.Faction = Constants.Mage.FACTION;
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
