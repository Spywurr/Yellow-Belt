namespace Kata_10___Extracting_Interfaces_to_Reduce_Code_Duplication;

public class Merchant : ISpeak
{
    private string Name = "Charsi";

    public void Speak()
    {
        Console.WriteLine($"{Name} says: I have many wares!");
    }
}