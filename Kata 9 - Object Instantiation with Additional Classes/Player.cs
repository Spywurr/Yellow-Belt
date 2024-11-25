namespace Kata_9___Object_Instantiation_with_Additional_Classes;

public class Player
{
    private string name;
    private int health;
    private int level;

    public Player(string name, int health, int level) // constructor
    {
        Name = name;
        Health = health;
        this.level = level;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Invalid name. Setting name to Arin.");
                name = "Arin";
            }
            else
            {
                name = value;
            }
        }
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100)
            {
                health = 100;
                Console.WriteLine("Maximum HP is 100. Setting HP to 100.");
            }
            else if (value < 1)
            {
                health = 1;
                Console.WriteLine("Minimum HP is 1. Setting HP to 1.");
            }
            else
            {
                health = value;
            }
        }
    }

    public void Attack(Enemy enemy, int damage)
    {
        Console.WriteLine($"{name} attacks {enemy.Type} and deals {damage} damage.");
    }
}