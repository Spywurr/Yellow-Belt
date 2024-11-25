namespace Kata_10___Extracting_Interfaces_to_Reduce_Code_Duplication;

public class Player : ISpeak, IDamageable
{
    public string Name;
    public int Health;
    public int Damage { get; private set; }

    public Player(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: I am ready for battle!");
    }

    public void TakeDamage(int damage)
    {
        Health -= Damage;
        Console.WriteLine($"{Name} takes {damage} points of damage. Remaining health: {Health}.");
    }

    public void DealDamage(Enemy enemy, int damage)
    {
        Console.WriteLine($"{Name} attacks {enemy.Name} and deals {damage} damage.");
        enemy.TakeDamage(damage);
    }
}



