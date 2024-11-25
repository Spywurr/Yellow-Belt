namespace Mini_Kata_7___Object_Instantiation;


/*
    Define a simple Player class with the following properties:
    Name (string): The player's name.
    Health (int): The player’s health points.
    Level (int): The player’s level.
    Define a simple Enemy class with the following properties:
    Type (string): The type of enemy (e.g., "Goblin").
    Health (int): The enemy’s health points.
    Damage (int): The enemy’s attack damage.
    In the Main method:
    Create an instance of Player, setting initial values for Name, Health, and Level.
    Create an instance of Enemy, setting initial values for Type, Health, and Damage.
    Display the properties of both objects in the console.
    */



class Program
{
    static void Main(string[] args)
    {
        Player player1 = new();
        player1.Name = "Arin";
        player1.Health = 100;
        player1.Level = 1;

        Enemy enemy1 = new();
        enemy1.Type = "Goblin";
        enemy1.Health = 50;
        enemy1.Damage = 10;


        Console.WriteLine("\nPlayer Info:");
        Console.WriteLine($"Name: {player1.Name}");
        Console.WriteLine($"Health: {player1.Health}");
        Console.WriteLine($"Level: {player1.Level}");
        
        Console.WriteLine("\nEnemy Info:");
        Console.WriteLine($"Name: {enemy1.Type}");
        Console.WriteLine($"Health: {enemy1.Health}");
        Console.WriteLine($"Level: {enemy1.Damage}");
    }
    

    
    
        
    
}

public class Player
{
    public string Name;
    public int Health;
    public int Level;
}
public class Enemy

{
    public string Type;
    public int Health;
    public int Damage;
}