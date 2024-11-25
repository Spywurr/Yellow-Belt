namespace Exam_Kata;

public class Game
{
    private Player _player;
    private Random _random;
    private List<object> _encounters;
    private string _lastEncounter;
    private int _consecutiveCombatCount;

    public Game()
    {
        _random = new Random();
        _encounters = new List<object>();
        _lastEncounter = string.Empty;
        _consecutiveCombatCount = 0;
    }

    public void Setup()
    {
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        _player = new Player(playerName);
        _encounters.Add(new NPC("Villager"));
        _encounters.Add(new Merchant("Merchant"));
    }

    public void Start()
    {
        while (_player.Health > 0)
        {
            object encounter = SelectEncounter();

            if (encounter is ICombat combatant)
            {
                HandleCombat(combatant);
                _lastEncounter = "Combat";
                _consecutiveCombatCount++;
            }

            if (encounter is ISpeakable speaker)
            {
                speaker.Speak();
                _lastEncounter = "Speak";
            }

            if (encounter is ITradeable trader)
            {
                trader.Trade(_player);
                _lastEncounter = "Trade";
                _consecutiveCombatCount = 0;
            }
        }

        Console.WriteLine("Game Over! You have been defeated.");
    }

    private object SelectEncounter()
    {
        object encounter = null;

        if (_consecutiveCombatCount >= 5)
        {
            encounter = new Merchant("Merchant");
            _consecutiveCombatCount = 0;
        }
        else
        {
            int encounterChoice = _random.Next(1, 4);

            if (encounterChoice == 1)
            {
                encounter = new Enemy("Goblin", _random.Next(20, 50), _random.Next(5, 15));
            }
            else
            {
                encounter = _encounters[_random.Next(_encounters.Count)];
            }
        }

        if (_lastEncounter == "Speak" || _lastEncounter == "Trade")
        {
            while ((encounter is NPC && _lastEncounter == "Speak") ||
                   (encounter is Merchant && _lastEncounter == "Trade"))
            {
                encounter = _encounters[_random.Next(_encounters.Count)];
            }
        }

        return encounter;
    }

    private void HandleCombat(ICombat enemy)
    {
        Console.WriteLine($"A wild {enemy.GetType().Name} appears!");
        while (_player.Health > 0 && enemy is ICombat target)
        {
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1. Attack");

            if (_player.Health < _player.MaxHealth)
            {
                Console.WriteLine("2. Heal");
            }

            string choice = Console.ReadLine();
            int action = Merchant.ValidateMenuChoice(choice, 1, _player.Health < _player.MaxHealth ? 2 : 1);

            if (action == 1)
            {
                _player.Attack(target);
                if (target is Enemy e && e.Health <= 0)
                {
                    int goldDropped = ((Enemy)e).DropGold();
                    _player.Gold += goldDropped;
                    Console.WriteLine($"The {e.Type} is defeated! You gain {goldDropped} gold.");
                    _player.GainExperience(30);
                    break;
                }
            }
            else if (action == 2 && _player.Health < _player.MaxHealth)
            {
                _player.Heal();
            }

            if (_player.Health > 0)
            {
                ((Enemy)target).Attack(_player);
            }
        }
    }
}