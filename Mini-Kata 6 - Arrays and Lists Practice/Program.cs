namespace Mini_Kata_6___Arrays_and_Lists_Practice;


//      Create an array of enemy names (e.g., "Goblin", "Orc", "Troll") and display each name using a loop.
//      Create a list of player inventory items (e.g., "Sword", "Shield", "Potion") and display each item in the list using a loop.
//      Add a new item to the inventory list (e.g., "Helmet") and display the updated list.


class Program
{
    static void Main(string[] args)
    {
        string[] enemyNames = new string[3];
        enemyNames[0] = "Goblin";
        enemyNames[1] = "Orc";
        enemyNames[2] = "Troll";

        Console.WriteLine("List of enemies:");
        foreach(var enemy in enemyNames)
        {
            Console.WriteLine(enemy);
        }

        Console.WriteLine("\nList of items:");

        List<string> itemsInInventory = new List<string>();
        itemsInInventory.Add("Sword");
        itemsInInventory.Add("Shield");
        itemsInInventory.Add("Potion");

        foreach (var item in itemsInInventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nUpdated list of items:");

        itemsInInventory.Add("Helmet");

        foreach (var item in itemsInInventory)
        {
            Console.WriteLine(item);
        }

    }
}