namespace Kata_10___Extracting_Interfaces_to_Reduce_Code_Duplication;

public class Enemy : ISpeak, IDamageable
{
    public string Name;
    public int Health;
    public int Damage;

    public Enemy(string name, int health, int damage)
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
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} points of damage. Remaining health: {Health}.");
    }

    public void DealDamage(int damage)
    {
        
    }
}