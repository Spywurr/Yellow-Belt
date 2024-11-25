namespace Exam_Kata;

public class Player : ICombat
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public int Gold { get; internal set; }
    public int Damage { get; private set; }

    public Player(string name)
    {
        Name = name;
        MaxHealth = 100;
        Health = MaxHealth;
        Level = 1;
        Experience = 0;
        Gold = 50;
        Damage = 20;
    }

    public void Attack(ICombat target)
    {
        Console.WriteLine($"{Name} attacks for {Damage} damage.");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} takes {damage} damage. Health left: {Health}");
    }

    public void Heal()
    {
        int healing = 20;
        Health += healing;
        if (Health > MaxHealth) Health = MaxHealth;
        Console.WriteLine($"{Name} heals for {healing} health. Health: {Health}");
    }

    public void GainExperience(int amount)
    {
        Experience += amount;
        Console.WriteLine($"{Name} gains {amount} experience. Total experience: {Experience}");

        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level++;
        Experience = 0;
        Health = MaxHealth;
        Console.WriteLine($"{Name} has leveled up! Level: {Level}, Health restored.");
        Damage += 5;
    }

    public void Buy(Item item)
    {
        if (Gold >= item.Price)
        {
            Gold -= item.Price;
            Console.WriteLine($"{Name} bought a {item.Name} for {item.Price} gold. Remaining gold: {Gold}");
        }
        else
        {
            Console.WriteLine($"Not enough gold to buy {item.Name}. You need {item.Price - Gold} more gold.");
        }
    }
}
