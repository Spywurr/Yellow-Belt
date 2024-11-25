namespace Kata_10___Extracting_Interfaces_to_Reduce_Code_Duplication;

public class NPC : ISpeak
{
    private string Name = "Deckard";

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Stay a while and listen.");
    }
}