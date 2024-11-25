namespace Kata_7___Classes_and_Objects;



/*Define a Player class with the following properties and methods:
Properties:
Name (string): The player's name.
Health (int): The player’s health points.
Level (int): The player’s level.
Experience (int): The player’s experience points.
Damage (int): The enemy’s attack damage.
Methods:
Attack(int damage): A method that deals damage to the enemy.
GainExperience(int exp): A method that increases the player’s experience by a specified amount and displays a message.
Define an Enemy class with the following properties and methods:
Properties:
Type (string): The type of enemy (e.g., "Orc").
Health (int): The enemy’s health points.
Methods:
TakeDamage(int damage): A method that reduces the enemy’s health by a specified damage amount and displays a message if the enemy is defeated (i.e., Health <= 0).
In the Main method:
Create instances of Player and Enemy and initialize their properties.
Call Attack on the player to attack the enemy.
Call TakeDamage on the enemy to reduce its health.
Call GainExperience on the player to add experience points.*/



class Program
{
    static void Main(string[] args)
    {
        Player player1 = new();
        player1.Name = "Arin";
        player1.Health = 100;
        player1.Level = 1;
        player1.Experience = 0;
        player1.Damage = 20;

        Enemy enemy1 = new();
        enemy1.Name = "Orc";
        enemy1.Health = 50;
        


        player1.PlayerAttack(enemy1, player1.Damage);
        enemy1.TakeDamage(player1, player1.Damage);
        player1.GainExperience(player1.Experience);

    }


}



class Player
{
    public string Name;
    public int Health;
    public int Level;
    public int Experience;
    public int Damage;
    
    public void PlayerAttack(Enemy enemy1, int damage)
    {
        Console.WriteLine($"{Name} attacks the {enemy1.Name} and deals {damage} damage.");
    }

    public void GainExperience(int exp)
    {
        Console.WriteLine($"Player {Name} gains {exp} experience points.");
    }
    
}
class Enemy
{
    public string Name;
    public int Health;

    public int TakeDamage(Player player1, int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}.");
        return player1.Experience += 50;
    }

}