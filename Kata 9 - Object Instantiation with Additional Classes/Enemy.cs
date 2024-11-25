namespace Kata_9___Object_Instantiation_with_Additional_Classes;

public class Enemy
{
    public string Type { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Enemy(string type, int health, int damage) // constructor
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damageTaken)
    {
        Health -= damageTaken;

        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine($"{Type} takes {damageTaken} damage. Remaining health: {Health}");
    }
}

