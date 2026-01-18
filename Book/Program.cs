
using System;
using System.Runtime;
using Book.Classes;
using Book.Classes.Animal;
using Book.Classes.BirdBook;
using Book.Classes.Cards;
using Book.Classes.Damage;
using Book.Classes.Schoes;
using Book.Interfaces;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    static Random random = new Random();

    static ShoeCloset shoeCloset = new ShoeCloset();

    static void Main(string[] args)
    {

        LinqComics();

        //LumberJacks();

       // KolodaCards();

      // Ducks();
       // Schoes();

       // MyCard();
        //testHH();

       // Animals();
       // Tall();
       // VendingMachineM();

        // SwordDamageMagiceGame();
        // MagiceGame();

       // BerdClass();
        // BigSmall();

        // DependecyInjection();
        // TestDraive(); 
        // Elephants();

    }

    public static void LinqComics()
    {
        AddSubtract a = new AddSubtract() { Value = 5 }
            .Add(5)
            .Subtract(3)
            .Add(9)
            .Subtract(12);
        Console.WriteLine($"Result: {a.Value}");

        Console.WriteLine("---------");

        IEnumerable<Comic> mostExpensive =
            from comic in Comic.Catalog
            where Comic.Prices[comic.Issue] > 50
            orderby Comic.Prices[comic.Issue]
            select comic;
        foreach (Comic comic in mostExpensive)
        {
            Console.WriteLine($"{comic}");
        }
    }

    public static void LumberJacks()
    {
        Random random = new Random();
        Queue<Lumberjack> queueLumberjack = new Queue<Lumberjack>();

        Console.Write("First lumberjack's name: ");
        var name = "";
        while ((name = Console.ReadLine()) != "")
        {
            Console.Write("Number of flapjacks: ");
            var lumberjack = new Lumberjack() { Name = name };
            if (int.TryParse(Console.ReadLine(), out var value))
            {        
                for (int i = 0; i < value; i++)
                {
                    lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
                }
            }
            queueLumberjack.Enqueue(lumberjack);
            Console.Write("\n Next lumberjack's name (blank to end): ");
        }
        while(queueLumberjack.Count > 0)
        {
            var lumber = queueLumberjack.Dequeue();
            lumber.EatFlapjacks();
            
        }
    }

    public static void KolodaCards()
    {
        List<Card> cards = new List<Card>();

        Console.Write("\n Enter number of cards: ");
        if (int.TryParse(Console.ReadLine(), out var cardsValue)) {
            if (cardsValue > 0 && cardsValue <= 56)
            {
                for (int i = 0; i < cardsValue; i++)
                {
                    cards.Add(RandomCard());
                }
            }
        }

        Console.WriteLine("... sorting the cards...");
        cards.Sort(new CardComparerByValue());

        foreach (Card card in cards) { 
            
            Console.WriteLine(card.Name);
        }

    }

    public static void PrintCard()
    {

    }

    public static Card RandomCard()
    {
        Random random = new Random();
        var numberBetween0And3 = random.Next(4);
        var numberBetween1And13 = random.Next(1, 14);
       // var anyRandomInteger = random.Next();

        Card card = new Card(numberBetween1And13, numberBetween0And3);
        Console.WriteLine(card.Name);
        return card;
    }

    public static void Ducks()
    {

        List<Duck> ducks = new List<Duck>() {
            
            new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
            new Duck() {Kind = KindOfDuck.Muscovy, Size = 18},
            new Duck() {Kind = KindOfDuck.Loon, Size = 14},
            new Duck() {Kind = KindOfDuck.Muscovy,Size = 11},
            new Duck() {Kind = KindOfDuck.Mallard,Size = 14},
            new Duck() {Kind = KindOfDuck.Loon, Size = 13},
        };
        ducks.Sort((IComparer<Duck>)new DuckComparerBySize());
        PrintDucks(ducks);

        IEnumerable<Bird> birds = ducks;
        Bird.FlyAway(birds.ToList(), "Minesota");

    }

    public static void PrintDucks(List<Duck> ducks)
    {
        foreach (Duck duck in ducks)
        {
            Console.WriteLine($"{duck}");
        }
    }

    public static void Schoes()
    {
        while (true) {
            
            shoeCloset.PrintShoes();
            Console.Write("\n Press 'a' to add or 'r' to remove a shoe: ");
            char key = Console.ReadKey().KeyChar;

            switch (key)
            {
                case 'a':
                case 'A':
                    shoeCloset.AddShoe();
                    break;
                case 'r':
                case 'R':
                    shoeCloset.RemoveShoe();
                    break;
                default:
                    return;
            }
        }
    }

    public static void MyCard()
    {
        Random random = new Random();
        var numberBetween0And3 = random.Next(4);
        var numberBetween1And13 = random.Next(1, 14);
        var anyRandomInteger = random.Next();

        Card card = new Card (numberBetween1And13, numberBetween0And3);
        Console.WriteLine (card.Name);
    }

    public static void testHH()
    {
        // 1 задача
        string inputValue = "";
        string inputeName = "";
        //-------------

        var studentNames = new List<string>();

        string[] values = inputValue.Split(',');
        string[] names = inputeName.Split(',');

        var ii = 0;

        foreach (string value in values)
        {

            if (int.TryParse(value, out int val))
            {
                if(val >= 49 && val <= 59)
                {
                    studentNames.Add(names[ii]);
                }
            }
            ii++;
        }

        if (studentNames.Count == 0)
        {
            studentNames.Add("none");
        }

        //return studentNames;
        // конец 1 задачи

        // 2 задача
        string inputNamees = "";
        string inputeFamilis = "";
        //-------------

        string[] namees = inputNamees.Split(',');
        string[] famils = inputeFamilis.Split(',');

        string name = "";
        string famil = "";

        for (int i = 0; i < famils.Length; i++)
        {
            if (i == 0) { name = names[i]; famil = famils[i]; continue; }

            if (famil.Length < famils[i].Length) { name = names[i]; famil = famils[i]; continue; }

            if (famil.Length == famils[i].Length)
            {
                if (name.Length < namees[i].Length)
                {
                    name = names[i]; famil = famils[i]; continue;
                }
             }
        }

       // return $"{name};{famil}";
       // конец 2 задачи




    }

    public static void Animals()
    {
        Animal[] animals =
        {
            new Wolf(false),
            new Hippo(),
            new Wolf(true),
            new Wolf(false),
            new Hippo()
        };
        foreach (var animal in animals)
        {
            animal.MakeNois();
            if (animal is IPackHunter hunter)
            {
                hunter.HuntInPack();
            }
            if (animal is ISwimmer swimmer)
            {
                swimmer.Swim();
            }
            Console.WriteLine();
        }
    }

    public static void Tall()
    {
        TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimy"};
        tallGuy.TalkAboutYourself();
        Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
        tallGuy.Honk();


    }
    public static void VendingMachineM()
    {
        VendingMachine vendingMachine = new AnimalFeedVendingMachine();
        Console.WriteLine(vendingMachine.Dispense(2.00M));
    }

    // Magice Game
    public static void SwordDamageMagiceGame()
    {

       WeaponDamage damageService;
        int numberOfRoll = 3;

        Console.WriteLine(" \nS for sword, A for arrow, anuthing else to quit: ");
        var weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

        switch (weaponKey)
        {
            case 'S':
                damageService = new SwordDamage(RollDice(numberOfRoll));
                break;
            case 'A':
                numberOfRoll = 1;
                damageService = new ArrowDamage(RollDice(numberOfRoll));
                break;

            default:
                return;
        }

        while (true)
        {
            Console.Write($"\n0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            var key = Console.ReadKey(false).KeyChar;

            if (key != '0' && key != '1' && key != '3' && key != '2') return;

            damageService.Roll = RollDice(numberOfRoll);
            damageService.Magic = (key == '1' || key == '3');
            damageService.Flaming = (key == '2' || key == '3');

            Console.WriteLine($"\n Rolled {damageService.Roll} for {damageService.Damage} HP \n");
        }

    }

    public static int RollDice(int numberOfRoll)
    {
        int value = 0;

        for (int i = 0; i < numberOfRoll; i++)
        {
            value += random.Next(1, 7);
        }

        return value;
    }
    public static void MagiceGame()
    {
        AbilityScoreCalculator calculator = new AbilityScoreCalculator();

        while (true)
        {
            calculator.RollResult = ReadInt(calculator.RollResult, $"Starting 4d6 roll");
            calculator.DivideBy = ReadDouble(calculator.DivideBy, $"Divide by");
            calculator.AddAmount = ReadInt(calculator.AddAmount, $"Add amount");
            calculator.Minimum = ReadInt(calculator.Minimum, $"Minimum"); 

            calculator.CalculateAbilityScore();

            Console.WriteLine($"Calculated ability score: {calculator.Score}");
            Console.WriteLine($"Press Q to quit, any other key to continue");
            char keyChar = Console.ReadKey(true).KeyChar;
            if ((keyChar == 'Q') || (keyChar == 'Q')) return;
        }

    }
    //

    public static void BerdClass()
    {
        while (true) {

            Bird bird;
            Console.Write("\nPress P for pigeon, O for ostrich: ");

            char key = Char.ToUpper(Console.ReadKey().KeyChar);
           // if (key == 'P') bird = new Pigeon();
            //else if (key == 'O') bird = new Ostrich();
            //else return;

            Console.Write("\nHow many eggs should it lay? ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
           // Egg[] eggs = bird.LayEggs(numberOfEggs);
            //foreach (Egg egg in eggs)
            //{
             //   Console.WriteLine(egg.Description);
            //}
        
        }
    }

    public static void BigSmall()
    {
        Console.WriteLine($"Welcome");
        Console.WriteLine($"Guess numbers between 1 and {HiloGame.MAXIMUM}.");
        HiloGame.Hint();

        while (HiloGame.GetPot > 0)
        {
            Console.WriteLine("Press h for higher, 1 for lower, ? to buy a hint,");
            Console.WriteLine($"or any other key to quit with {HiloGame.GetPot}.");
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'h') HiloGame.Guess(true);
            else if (key == '1') HiloGame.Guess(false);
            else if (key == '?') HiloGame.Hint();
            else
            {
                return;
            }
        }
        Console.WriteLine("The pot is empty. By!");

    }


    static int ReadInt(int lastUsedValue, string promt)
    {

        Console.Write($"{promt} [ {lastUsedValue} ]");
        string line = Console.ReadLine();
        if (int.TryParse( line, out int value))
        {
            Console.WriteLine($" using value {value}");
            return value;
        } else
        {
            Console.WriteLine($" using default value {lastUsedValue}");
            return value;
        }
    }

    static double ReadDouble(double lastUsedValue, string promt)
    {

        Console.Write($"{promt} [ {lastUsedValue} ]");
        string line = Console.ReadLine();
        if (double.TryParse(line, out double value))
        {
            Console.WriteLine($" using value {value}");
            return value;
        }
        else
        {
            Console.WriteLine($" using default value {lastUsedValue}");
            return value;
        }
    }


    public static void DependecyInjection()
    {

        IServiceCollection services = new ServiceCollection();
       // var Emservice = new ServiceDescriptor(typeof(IMessageService), typeof(EmailService), ServiceLifetime.Scoped);
        //services.Add(service);
        services.AddScoped<IMessageService, EmailService>();

        var Loggerservice = new ServiceDescriptor(typeof(ILogger), typeof(ConsoleLogger), ServiceLifetime.Scoped);
        services.Add(Loggerservice);

        var service = new ServiceDescriptor(typeof(IDataBase), typeof(PostgresDataBase), ServiceLifetime.Scoped);
        services.Add(service);

        services.AddScoped<MessageService>();

        /*
        ILogger logger = new ConsoleLogger();
       IDataBase dataBase = new PostgresDataBase(logger);

       IMessageService messageService = new EmailService(logger, dataBase);
        */


        //var message = new MessageService(messageService);
        var serviceProvider = services.BuildServiceProvider();
        var messageService = serviceProvider.GetRequiredService<MessageService>();

        messageService.Notify();


    }

    public static void TestDraive()
    {
        Random random = new Random();
        int randomInt = random.Next();
        Console.WriteLine(randomInt);

        int zeroToNine = random.Next(10);
        Console.WriteLine(zeroToNine);

        int dieRoll = random.Next(1, 7);
        Console.WriteLine(dieRoll);

        double randomDouble = random.NextDouble();
        Console.WriteLine(randomDouble);
        Console.WriteLine(randomDouble * 100);
        Console.WriteLine((float)randomDouble * 100F);
        Console.WriteLine((decimal)randomDouble * 100M);

        int zeroOrOne = random.Next(2);
        bool coinFlip = Convert.ToBoolean(zeroOrOne);
        Console.WriteLine(coinFlip);
    }

    public static void Elephants()
    {

        Elephant lucinda = new Elephant() { Name = "Lusinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        Console.WriteLine($"Press 1 for Lloyd, 2 for Lucinda, 3 to swap");


        while (true)
        {
            Console.Write($"You pressed ");
            string svalue = Console.ReadLine();

            /* char input = Console.ReadKey(true).KeyChar;
            if (input == '1')
            */

            short.TryParse(svalue, out short value);
            if (value == 1)
            {
                lloyd.WhoAml();
            }
            else if (value == 2)
            {
                lucinda.WhoAml();
            }
            else if (value == 3)
            {
                Elephant otherElephant = lucinda;
                lucinda = lloyd;
                lloyd = otherElephant;
                Console.WriteLine($"Refences have been swapped");
            }
            else if (value == 4)
            {
                lloyd = lucinda;
                lloyd.EarSize = 4321;
                lloyd.WhoAml();
            }
            else if (value == 5)
            {
                lucinda.SpeakTo(lloyd, $"Hi, " + lloyd.Name);
            }
            else
            {
                return;
            };


        
        }


    }

}



