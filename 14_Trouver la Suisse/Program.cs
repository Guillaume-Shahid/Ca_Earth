public static class Program
{
    private static bool CheckIfThreeArgsExists(string[] args)
    {
        if(args.Length != 4)
        {
            return false;   
        }
        return true;
    }

    private static bool CheckIfArgsAreNumber(string[] args)
    {
        try
        {
            int arg1 = Int32.Parse(args[1]);
            int arg2 = Int32.Parse(args[2]);
            int arg3 = Int32.Parse(args[3]);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private static bool CheckIfAllNumberAreDifferent(string[] args)
    {
        for (int i = 1; i < 3; i++)
        {
            for (int j = (i + 1); j <= 3; j++)
            {
                if (Int32.Parse(args[i]) == Int32.Parse(args[j]))
                {
                    return false;
                }
            }
        }
        return true;
    }

    private static int FindSwiss(string[] args)
    {
        List<int> argsInInt = new List<Int32>();
        
        foreach (var value in args)
        {
            if (value == "Program.cs")
            {
                continue;
            }
            argsInInt.Add(Int32.Parse(value));
        }
        argsInInt.Sort();
        
        return argsInInt[1];
    }
    
    public static void Main(string[] args)
    {
        if (CheckIfThreeArgsExists(args) && CheckIfArgsAreNumber(args))
        {
            if (CheckIfAllNumberAreDifferent(args))
            {
                Console.WriteLine(FindSwiss(args));
            }
            else
            {
                Console.WriteLine("Erreur.");
            }
        }
        else
        {
            Console.WriteLine("Tu dois rentrer trois arguments et trois nombres entiers");
        }
    }
}
