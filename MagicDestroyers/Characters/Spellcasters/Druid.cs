//using MagicDestroyers.Characters.Spellcasters;
//using MagicDestroyers.Enumerations;
//using System;

//public class Druid : Spellcaster
//{
//    //default character values
//    private const string DEFAULT_NAME = "DBob";
//    private const Faction DEFAULT_FACTION = Faction.Spellcaster;

//    private const int DEFAULT_LEVEL = 1;
//    private const int DEFAULT_MANA_POINTS = 20;
//    private const int DEFAULT_HEALTH_POINTS = 100;

//    private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
//    private readonly Staff DEFAULT_WEAPON = new Staff();

    
//    public Druid()
//        : this(DEFAULT_NAME, DEFAULT_LEVEL)
//    {
//    }

//    public Druid(string name, int level)
//        : this(name, level, DEFAULT_MANA_POINTS)
//    {
//    }

//    public Druid(string name, int level, int manaPoints)
//        : base(name, level, manaPoints)
//    {
//        base.HealthPoints = DEFAULT_HEALTH_POINTS;
//        base.Faction = DEFAULT_FACTION;
//        base.BodyArmor = DEFAULT_ARMOR;
//        base.Weapon = DEFAULT_WEAPON;
//    }

//    public override void BasicAttack()
//    {
//        this.Moonfire();
//    }

//    public override void SpecialAttack()
//    {
//        this.Starburst();
//    }

//    public override void Defend()
//    {
//        this.OneWithNature();
//    }
//    public void Moonfire()
//    {
//        throw new NotImplementedException();
//    }

//    public void Starburst()
//    {
//        throw new NotImplementedException();
//    }

//    public void OneWithNature()
//    {
//        throw new NotImplementedException();
//    }
//}