namespace Kata_8___Encapsulation_and_Access_Modifiers;


//     Update the Player class:
//     Private Fields: Convert Health, Level, and Experience to private fields.
//     Public Properties: Create public properties for Health, Level, and Experience with appropriate getters and setters.
//     Ensure Health can be accessed but only modified within the class itself.
//     Ensure Level and Experience can be set by other classes but have validation in the setter to prevent negative values.
//     Create a private method LevelUp() that increases Level by 1 and resets Experience to 0.
//     Update GainExperience(int exp) to call LevelUp() if Experience reaches or exceeds 100.
//     In the Main method:
//     Create a Player instance and call GainExperience to test the level-up logic.
//     Try directly setting Health outside the class to verify encapsulation (this should produce an error if Health is correctly encapsulated).


class Program
{
    static void Main(string[] args)
    {
        Player player1 = new();
        player1.Health = 199;
        player1.Level = 1;
        player1.Experience = 1;
        
        Console.WriteLine($"Player Health: {player1.Health}");
        Console.WriteLine($"Player Level: {player1.Level}");
        Console.WriteLine($"Player Experience: {player1.Experience}");
        
        player1.GainExperience(50);
        player1.GainExperience(60);
        

    }


}