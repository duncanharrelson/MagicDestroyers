using MagicDestroyers;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using System;

public class Warrior : Melee
{
    private readonly ChainLink DEFAULT_ARMOR = new ChainLink();
    private readonly Axe DEFAULT_WEAPON = new Axe();

    //basic class constructor with no input
    public Warrior()
        : this(Constants.Warrior.NAME, 1)
    {
    }

    //Chained constructor inputs values above for name and level arguments
    public Warrior(string name, int level)
        : this(name, level, Constants.Warrior.ABILITY_POINTS)
    {
    }

    public Warrior(string name, int level, int abilityPoints)
        : base(name, level, abilityPoints)
    {
        base.HealthPoints = Constants.Warrior.HEALTH_POINTS;
        base.Faction = Constants.Warrior.FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
        base.IsAlive = true;
        base.Scores = 0;
    }

    public override int BasicAttack()
    {
        return this.Strike();
    }

    public override int SpecialAttack()
    {
        return this.Execute();
    }

    public override int Defend()
    {
        return this.SkinHarden();
    }

    public int Strike()
    {
        return base.Weapon.Damage + 10;
    }

    public int Execute()
    {
        throw new NotImplementedException();
    }

    public int SkinHarden()
    {
        return base.BodyArmor.ArmorPoints + 5;
    }
}

