
using Book.Classes;
using Book.Interfaces;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{

    private static void Main(string[] args)
    {




        MagiceGame();

       // DependecyInjection();
        //TestDraive(); 
      //  Elephants();
        
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



