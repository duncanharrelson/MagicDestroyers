using MagicDestroyers;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Assassin : Melee
{
    private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
    private readonly Sword DEFAULT_WEAPON = new Sword();

    public Assassin()
        : this(Constants.Assassin.NAME, Constants.Assassin.LEVEL)
    {
    }

    public Assassin(string name, int level)
        : this(name, level, Constants.Assassin.ABILITY_POINTS)
    {
    }

    public Assassin(string name, int level, int abilityPoints)
        : base(name, level, abilityPoints)
    {
        base.HealthPoints = Constants.Assassin.HEALTH_POINTS;
        base.Faction = Constants.Assassin.FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
    }

    public override int BasicAttack()
    {
        return this.Raze();
    }

    public override int SpecialAttack()
    {
        return this.Bleed();
    }

    public override int Defend()
    {
        return this.Survival();
    }

    public int Raze()
    {
        return base.Weapon.Damage + 10;
    }

    public int Bleed()
    {
        throw new NotImplementedException();
    }

    public int Survival()
    {
        return base.BodyArmor.ArmorPoints + 5;
    }
}