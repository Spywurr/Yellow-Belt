namespace Exam_Kata;

public class Merchant : ISpeakable, ITradeable
{
    public string Name { get; private set; }
    public List<Item> Inventory { get; private set; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new List<Item>
        {
            new Item("Sword", 30),
            new Item("Shield", 40),
            new Item("Potion", 10)
        };
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Take a look at my wares.");
    }

    public void Trade(Player player)
    {
        bool shopping = true;

        while (shopping)
        {
            Console.WriteLine("Available items for purchase:");
            for (int i = 0; i < Inventory.Count; i++)
            {
                var item = Inventory[i];
                Console.WriteLine($"{i + 1}. {item.Name} - {item.Price} gold");
            }
            Console.WriteLine("Which item would you like to buy? (Enter the number)");
            Console.WriteLine("Or press 0 to exit the shop.");

            string choice = Console.ReadLine();
            int itemIndex = ValidateMenuChoice(choice, 0, Inventory.Count);

            if (itemIndex == 0)
            {
                shopping = false;
                Console.WriteLine("You leave the merchant's shop.");
            }
            else
            {
                var selectedItem = Inventory[itemIndex - 1];

                if (player.Gold >= selectedItem.Price)
                {
                    player.Buy(selectedItem);

                    if (selectedItem.Name != "Potion")
                    {
                        Inventory.RemoveAt(itemIndex - 1);
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough gold to buy {selectedItem.Name}. You need {selectedItem.Price - player.Gold} more gold.");
                }
            }
        }
    }

    internal static int ValidateMenuChoice(string input, int minValue, int maxValue)
    {
        int result;
        while (!int.TryParse(input, out result) || result < minValue || result > maxValue)
        {
            Console.WriteLine($"Please enter a number between {minValue} and {maxValue}:");
            input = Console.ReadLine();
        }
        return result;
    }
}