using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Warrior : Melee
{
    //default character values
    private const string DEFAULT_NAME = "Bob";
    private const Faction DEFAULT_FACTION = Faction.Melee;

    private const int DEFAULT_LEVEL = 1;
    private const int DEFAULT_ABILITY_POINTS = 10;
    private const int DEFAULT_HEALTH_POINTS = 100;

    private readonly ChainLink DEFAULT_ARMOR = new ChainLink();
    private readonly Axe DEFAULT_WEAPON = new Axe();

    //basic class constructor with no input
    public Warrior()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
    {
    }

    //Chained constructor inputs values above for name and level arguments
    public Warrior(string name, int level)
        : this(name, level, DEFAULT_ABILITY_POINTS)
    {
    }

    public Warrior(string name, int level, int abilityPoints)
        : base(name, level, abilityPoints)
    {
        base.HealthPoints = DEFAULT_HEALTH_POINTS;
        base.Faction = DEFAULT_FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
    }

    public override int BasicAttack()
    {
        return this.Strike();
    }

    public override int SpecialAttack()
    {
        return this.Execute();
    }

    public override void Defend()
    {
        this.SkinHarden();
    }

    public int Strike()
    {
        return base.Weapon.Damage + 10;
    }

    public int Execute()
    {
        throw new NotImplementedException();
    }

    public void SkinHarden()
    {
        throw new NotImplementedException();
    }
}

