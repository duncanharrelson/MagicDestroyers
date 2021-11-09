using System;

public class Sword
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

    public Sword()
    {
        this.Damage = 10;
    }

    public void Bloodthirst()
    {
        throw new NotImplementedException();
    }
}
