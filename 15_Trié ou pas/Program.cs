using System;
public static class Program
{
    private static bool CheckIfOneArgsExists(string[] args)
    {
        if(args.Length < 2)
        {
            return false;   
        }
        return true; 
    }

    private static bool CheckIfAllArgsAreNumber(string[] args)
    {
        foreach (var number in args)
        {
            if (number == "Program.cs")
            {
                continue;
            }
            if (!Int32.TryParse(number, out _))
            {
                return false;
            }
        }

        return true;
    }

    private static string isListSorted(string[] args)
    {
        if (args.Length <= 2)
        {
            return $"Tu as rentré que {Int32.Parse(args[1])}, on va dire que c'est trié...";
        }

        for (int i = 2; i < args.Length; i++)
        {
            if (Int32.Parse(args[i - 1]) > Int32.Parse(args[i]))
            {
                return "Pas triée!";
            }
        }

        return "Triée!";
    }
    public static void Main(string[] args)
    {
        if (CheckIfOneArgsExists(args))
        {
            if (CheckIfAllArgsAreNumber(args))
            {
                Console.WriteLine(isListSorted(args));
            }
            else
            {
                Console.WriteLine("Tu dois rentrer que des nombres");
            }
        }
        else
        {
            Console.WriteLine("Tu dois rentrer au moins un argument");
        }
    }
}