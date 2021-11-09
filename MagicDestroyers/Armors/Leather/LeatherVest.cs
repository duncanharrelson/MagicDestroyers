using System;

public class LeatherVest
{
    private int armorPoints;

    public int ArmorPoints
    {
        get
        {
            return this.armorPoints;
        }
        set
        {
            if (value >= 1 && value <= 100)
            {
                this.armorPoints = value;
            }
            else
            {
                Console.WriteLine("Inappropriate value!  Must be between 1 and 100!");
            }

        }
    }

    public LeatherVest()
    {
        this.ArmorPoints = 10;
    }
}