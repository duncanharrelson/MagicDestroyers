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

    public Knight()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    public Knight(string name, int level)
        : this(name, level, DEFAULT_HEALTH_POINTS)
    {
    }

    public Knight(string name, int level, int abilityPoints)
        : base(name, level, abilityPoints)
    {
        base.HealthPoints = DEFAULT_HEALTH_POINTS;
        base.Faction = DEFAULT_FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
    }

    public override void BasicAttack()
    {
        this.HolyBlow();
    }

    public override void SpecialAttack()
    {
        this.PurifySoul();
    }

    public override void Defend()
    {
        this.RighteousWings();
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

