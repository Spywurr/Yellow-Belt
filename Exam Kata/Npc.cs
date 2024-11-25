namespace Exam_Kata;

public class NPC : ISpeakable
{
    public string Name { get; private set; }

    public NPC(string name)
    {
        Name = name;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Welcome to our village!");
    }
}