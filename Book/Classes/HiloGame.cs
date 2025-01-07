
static class HiloGame
{
    public const int MAXIMUM = 10;
    private static Random random = new Random();
    private static int currentNumber = random.Next(1, MAXIMUM + 1);
    private static int pot = 10;
    public static int GetPot { get; private set; }

    // prop и 2 tab
   // public static int GetPot { get { return pot; } }

   

    internal static void Guess(bool higher)
    {
        int nextNumber = random.Next(0, MAXIMUM + 1);
        if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
        {
            Console.WriteLine("You guessed right");
            pot++;
        }
        else
        {
            Console.WriteLine("Bad luck");
            pot--;
        }
        currentNumber = nextNumber;
        Console.WriteLine($"The current number is {currentNumber}");
     }

    internal static void Hint()
    {
        var half = MAXIMUM / 2;
        if (currentNumber >= half) Console.WriteLine($"The number ia at least {half}");
        else Console.WriteLine($"The number ia at most {half}");
        pot--;
    }
}