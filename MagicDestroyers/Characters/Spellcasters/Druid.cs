using MagicDestroyers;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enumerations;
using System;

public class Druid : Spellcaster
{
   
    private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
    private readonly Staff DEFAULT_WEAPON = new Staff();


    public Druid()
        : this(Constants.Druid.NAME, Constants.Druid.LEVEL)
    {
    }

    public Druid(string name, int level)
        : this(name, level, Constants.Druid.MANA_POINTS)
    {
    }

    public Druid(string name, int level, int manaPoints)
        : base(name, level, manaPoints)
    {
        base.HealthPoints = Constants.Druid.HEALTH_POINTS;
        base.Faction = Constants.Druid.FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
    }

    public override int BasicAttack()
    {
        return this.Moonfire();
    }

    public override int SpecialAttack()
    {
        return this.Starburst();
    }

    public override int Defend()
    {
        return this.OneWithNature();
    }
    public int Moonfire()
    {
        throw new NotImplementedException();
    }

    public int Starburst()
    {
        throw new NotImplementedException();
    }

    public int OneWithNature()
    {
        throw new NotImplementedException();
    }
}