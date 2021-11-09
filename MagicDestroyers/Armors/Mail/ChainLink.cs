using System;

public class ChainLink
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

    public ChainLink()
    {
        this.ArmorPoints = 10;
    }
}
