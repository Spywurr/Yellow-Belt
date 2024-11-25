namespace Kata_8___Encapsulation_and_Access_Modifiers;

public class Player
{
    private int health;
    private int level;
    private int experience;


    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100)
            {
                health = 100;
            }

            else if (value < 1)
            {
                
                health = 0;
                Console.WriteLine("You are dead!");
            }
            else
            {
                health = value;
            }
        }
    }

    public int Level
    {
        get { return level; }
        set
        {
            if (value < 1)
            {
                level = 1;
            }
            else if (value > 99)
            {
                level = 99;
            }
            else
            {
                level = value;
            }
        }
    }

    public int Experience
    {
        get { return experience;  }
        set
        {
            if (value < 0)
            {
                experience = 0;
            }
            else
            {
                experience = value;
            }
        }
    }

    private void LevelUp()
    {
        level++;
        Console.WriteLine($"Congratulations, you've leveled up. New level: {level}");
        experience = 0;
    }

    public void GainExperience(int exp)
    {
        if (exp <= 0)
        {
            Console.WriteLine("Must be a positive integer.");
            return;
        }
        Experience += exp;
        Console.WriteLine($"Player gains {exp} experience.");
        if (Experience >= 100)
        {
            Experience = 0;
            LevelUp();
            
        } 
        
    
    }
}