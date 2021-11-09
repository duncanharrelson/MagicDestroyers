using System;

public class Staff
{
    private int damage;
    public int ArmorPoints
    {
        get
        {
            return damage;
        }
        set
        {
            if (value >= 1 && value <= 100)
            {
                damage = value;
            }
            else
            {
                Console.WriteLine("Inappropriate value!  Must be between 1 and 100!");
            }

        }
    }

    public Staff()
    {

    }

    public void Empower()
    {

    }
}