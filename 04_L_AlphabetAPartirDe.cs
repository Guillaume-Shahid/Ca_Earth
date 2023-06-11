class Program
{
    private static string DisplayLetters(string letterInArgs)
    {
        char firstArg = Char.Parse(letterInArgs);

        for(char letter = 'a'; letter <= 'z'; letter++)
        {
            if(letter >= firstArg)
            {
                return letter;
            }
        }
        return "";
    }

    private static bool CheckIfArgsExists(string[] args)
    {
        if(args.Length != 2)
        {
            return false;   
        }
        return true;
    }

    private static bool CheckIfThereIsOnlyOneLetter(string[] args)
    {
        if(args[1].Length != 1)
        {
            return false;
        }
        return true;
    }

    
    private static void Main(string[] args)
    {
        if(CheckIfArgsExists(args) && CheckIfThereIsOnlyOneLetter(args) && args[1].All(char.IsLetter))
        {
            DisplayLetters(args[1].ToLower());
        }
        else
        {
            Console.WriteLine("Tu dois entrer un unique argument avec un caractère valide (pas de chiffres ni caractères spéciaux)");
        }
    }
}