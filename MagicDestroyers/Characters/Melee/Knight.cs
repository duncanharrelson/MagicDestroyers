using MagicDestroyers;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Knight : Melee
{
    private readonly ChainLink DEFAULT_ARMOR = new ChainLink();
    private readonly Hammer DEFAULT_WEAPON = new Hammer();

    public Knight()
        : this(Constants.Knight.NAME, Constants.Knight.LEVEL)
    {
    }

    public Knight(string name, int level)
        : this(name, level, Constants.Knight.HEALTH_POINTS)
    {
    }

    public Knight(string name, int level, int abilityPoints)
        : base(name, level, abilityPoints)
    {
        base.HealthPoints = Constants.Knight.HEALTH_POINTS;
        base.Faction = Constants.Knight.FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
    }

    public override int BasicAttack()
    {
        return this.HolyBlow();
    }

    public override int SpecialAttack()
    {
        return this.PurifySoul();
    }

    public override int Defend()
    {
        return this.RighteousWings();
    }
    public int HolyBlow()
    {
        return base.Weapon.Damage + 10;
    }

    public int PurifySoul()
    {
        throw new NotImplementedException();
    }

    public int RighteousWings()
    {
        return base.BodyArmor.ArmorPoints + 5;
    }
}

