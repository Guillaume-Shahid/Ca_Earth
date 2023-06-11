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
    
   private static double SquareRoot(double valueToSquareRoot)
   {
    const int ITERATION_NUMBER = 10;
    double approximation = valueToSquareRoot;

    if(valueToSquareRoot == 0)
    {
        return 0;
    }

    for(int i = 0; i < ITERATION_NUMBER; i++)
    { 
        approximation = (approximation + (valueToSquareRoot / approximation)) / 2;
    }
    return approximation;
   }
    
    private static void Main(string[] args)
    {
        if(CheckIfOneArgsExists(args))
        {
            try
            {
                double numberToSquareRoot = Double.Parse(args[1]);
                if(numberToSquareRoot != 0)
                {
                    Console.WriteLine(SquareRoot(numberToSquareRoot));
                }
                else
                {
                    Console.WriteLine("Erreur");
                }
            }
            catch
            {
                Console.WriteLine("Tu dois rentrer un argument valide");
            }
        }
        else
        {
            Console.WriteLine("Tu dois rentrer un unique argument numérique");
        }

    }
}