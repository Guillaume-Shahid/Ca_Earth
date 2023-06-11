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
    
    private static bool IsNumberIsPrime(int number)
    {
        if(number < 2)
        {
            return false;
        }
        else
        {
            for(int i = 2; i < number; i++)
            {
                if((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    private static void Main(string[] args)
    {
        if(CheckIfOneArgsExists(args))
        {
            try
            {
                int numberInArgs = Int32.Parse(args[1]);

                if (numberInArgs >= 0)
                {
                    if(IsNumberIsPrime(numberInArgs))
                    {
                        Console.WriteLine($"Oui, {numberInArgs} est un nombre premier.");
                    }
                    else
                    {
                        Console.WriteLine($"Non, {numberInArgs} n'est pas premier.");
                    }   
                }
                else
                {
                    Console.WriteLine("Erreur");
                }
            }
            catch
            {
                Console.WriteLine("Erreur");
            }
        }
        else
        {
            Console.WriteLine("Tu dois rentrer un unique argument!");
        }
    }
}