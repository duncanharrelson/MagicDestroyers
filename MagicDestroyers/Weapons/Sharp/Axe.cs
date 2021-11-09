using System;

public class Axe
{
    private int damage;
    public int Damage
    {
        get
        {
            return this.damage;
        }
        set
        {
            if (value >= 1 && value <= 100)
            {
                this.damage = value;
            }
            else
            {
                Console.WriteLine("Inappropriate value!  Must be between 1 and 100!");
            }

        }
    }

    public Axe()
    {
        this.Damage = 10;
    }

    public void HackNSlash()
    {
        throw new NotImplementedException();
    }
}