class Program
{
     private static bool CheckIfOneArgsExists(string[] args)
    {
        if(args.Length != 2)
        {
            return false;   
        }
        return true;
    }

    private static string EvenOrOdd(int number)
    {
        if(number % 2 == 0)
        {
            return "pair";
        }
        return "Impair";
    }

    private static void Main(string[] args)
    {
        try
        {
            int number = Int32.Parse(args[1]);

            if(CheckIfOneArgsExists(args) && number >= 0)
            {
                Console.WriteLine(EvenOrOdd(number));
            }
            else
            {
                Console.WriteLine("Tu ne me la mettras pas à l’envers. Je veux un unique argument et surtout un nombre entier!!!");
            }
        }
        catch
        {
            Console.WriteLine("Tu ne me la mettras pas à l’envers. Je veux un nombre entier!!!");
        }
        
    }
}