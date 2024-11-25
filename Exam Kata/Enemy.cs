namespace Exam_Kata;

public class Enemy : ICombat
{
    public string Type { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void Attack(ICombat target)
    {
        Console.WriteLine($"{Type} attacks for {Damage} damage.");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
    }

    public int DropGold()
    {
        Random rand = new Random();
        int goldDropped = rand.Next(1, 31);
        Console.WriteLine($"{Type} dropped {goldDropped} gold.");
        return goldDropped;
    }
}