namespace Kata_9___Object_Instantiation_with_Additional_Classes;

public class Merchant
{
    public string Name { get; private set; }
    private List<Item> items;

    public Merchant()
    {
        Name = "Merchant";
        items = new List<Item>();
        items.Add(new Item("Sword"));
        items.Add(new Item("Shield"));
        items.Add(new Item("Potion"));
    }

    public void Trade()
    {
        string ItemList = string.Join(", ", items.Select(item => item.Name));
        Console.WriteLine($"{Name}'s inventory: {ItemList}");

    }

}

public class Item
{
    public string Name { get; private set; }

    public Item(string name)
    {
        Name = name;
    }
}