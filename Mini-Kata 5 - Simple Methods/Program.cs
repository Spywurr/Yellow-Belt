namespace Mini_Kata_5___Simple_Methods;


//     Create a method named Attack that takes an int parameter called damage and prints a message showing the damage dealt.
//     Create another method named Heal that takes an int parameter called healAmount and prints a message showing the health restored.
//     In the Main method, call both Attack and Heal with sample values to see the output.



class Program
{
    static void Main(string[] args)
    {
        Attack(15);
        Heal(10);

    }

    static void Attack(int damage)
    {
        Console.WriteLine($"Player dealt {damage} damage!");
    }

    static void Heal(int healAmount)
    {
        Console.WriteLine($"Player heals for {healAmount} health points!");
    }
    
    

}