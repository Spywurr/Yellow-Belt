namespace Kata_6___Arrays_and_Lists;


//     Create an array of five enemy names (e.g., "Goblin", "Orc", "Troll", "Skeleton", "Dragon") and display each name using a loop.
//     Create a list to represent the player’s inventory with three initial items (e.g., "Sword", "Shield", "Potion").
//     Display the list of inventory items using a loop.
//     Add two more items to the inventory (e.g., "Helmet" and "Armor").
//     Remove one item (e.g., "Potion").
//     Display the updated inventory list.
//     Display the count of items in the inventory list after modifications.


class Program
{
    static void Main(string[] args)
    {
        string[] enemyList = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
        Console.WriteLine("\nList of enemies:");
        foreach (var enemy in enemyList)
        {
            Console.WriteLine(enemy);
        }
        
        
        List<string> itemsInInventory = new List<string> { "Sword", "Shield", "Potion" };
        Console.WriteLine("\nList of items:");

        foreach (var item in itemsInInventory)
        {
            Console.WriteLine(item);
        }

        itemsInInventory.Add("Helmet");
        itemsInInventory.Add("Armor");
        itemsInInventory.Remove("Potion");

        Console.WriteLine("\nUpdated list:");
        foreach (var item in itemsInInventory)
        {
            Console.WriteLine(item);
            
        }
        Console.WriteLine($"\nTotal items in inventory: {itemsInInventory.Count}");
    } 
}