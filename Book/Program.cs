
using Book.Classes;
using Book.Interfaces;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{

    private static void Main(string[] args)
    {


        DependecyInjection();
        //TestDraive(); 
      //  Elephants();
        
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



