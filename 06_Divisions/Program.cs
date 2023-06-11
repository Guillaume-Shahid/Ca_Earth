internal partial class Program
{
    private static bool CheckIfTwoArgsExists(string[] args)
    {
        if(args.Length != 3)
        {
            return false;   
        }
        return true;
    }

    private static bool CheckIfSecondArgIsZero(string[] args)
    {
        if(args[2] == "0")
        {
            return false;
        }
        return true;
    }

    private static void Main(string[] args)
    {
        try
        {
            if(CheckIfTwoArgsExists(args))
            {
                int number1 = Int32.Parse(args[1]);
                int number2 = Int32.Parse(args[2]);

                if(CheckIfSecondArgIsZero(args) && number1 > number2)
                {
                    Console.WriteLine($"Résultat: {number1 / number2}");
                    Console.WriteLine($"Reste: {number1 % number2}");
                }
                else
                {
                    Console.WriteLine("Erreur.");
                }
            }
            else
            {
                Console.WriteLine("Erreur.");
            }
        }
        catch
        {
            Console.WriteLine("Erreur.");
        }
    }
}