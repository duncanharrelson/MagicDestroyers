using MagicDestroyers;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enumerations;
using System;

public class Necromancer : Spellcaster
{
    
    private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
    private readonly Sword DEFAULT_WEAPON = new Sword();

    public Necromancer()
        : this(Constants.Necromancer.NAME, Constants.Necromancer.LEVEL)
    {
    }

    public Necromancer(string name, int level)
        : this(name, level, Constants.Necromancer.MANA_POINTS)
    {
    }

    public Necromancer(string name, int level, int manaPoints)
        : base(name, level, manaPoints)
    {
        base.HealthPoints = Constants.Necromancer.HEALTH_POINTS;
        base.Faction = Constants.Necromancer.FACTION;
        base.BodyArmor = DEFAULT_ARMOR;
        base.Weapon = DEFAULT_WEAPON;
    }

    public override int BasicAttack()
    {
        return this.ShadowRage();
    }

    public override int SpecialAttack()
    {
        return this.VampireTouch();
    }

    public override int Defend()
    {
        return this.BoneShield();
    }

    public int ShadowRage()
    {
        return base.Weapon.Damage + 10;
    }

    public int VampireTouch()
    {
        throw new NotImplementedException();
    }

    public int BoneShield()
    {
        return base.BodyArmor.ArmorPoints + 5;
    }
}
