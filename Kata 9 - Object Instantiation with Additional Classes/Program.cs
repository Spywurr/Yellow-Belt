namespace Kata_9___Object_Instantiation_with_Additional_Classes;

class Program
{
    static void Main(string[] args)
    {
        Player player = new("", 100 , 1);
        Enemy enemy = new("Goblin", 50, 30);
        Merchant merchant = new();
        NPC npc = new();
        npc.Name = "Npc";

        int damage = 20;
        
        player.Attack(enemy, damage);
        enemy.TakeDamage(damage);
        npc.Speak();
        merchant.Trade();
        
    }
}