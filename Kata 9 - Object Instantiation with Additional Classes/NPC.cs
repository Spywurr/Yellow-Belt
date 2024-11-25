namespace Kata_9___Object_Instantiation_with_Additional_Classes;

public class NPC
{
    public string Name { get; set; }
    public string Dialogue = "Stay a while and listen";


    public void Speak()
    {
        Console.WriteLine($"{Name} says {Dialogue}");
    }
}