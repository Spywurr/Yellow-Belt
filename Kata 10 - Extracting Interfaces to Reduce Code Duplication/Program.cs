namespace Kata_10___Extracting_Interfaces_to_Reduce_Code_Duplication;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Conan", 100, 10);
        Enemy enemy = new Enemy("Goblin", 50, 10);
        NPC npc = new NPC();
        Merchant merchant = new Merchant();
        npc.Speak();
        merchant.Speak();
        player.Speak();
        enemy.Speak();
        player.DealDamage(enemy, player.Damage);
        
        
        

    }
}

interface ISpeak
{ 
    void Speak();

}

interface IDamageable
{
    void TakeDamage(int damage);
}