using System;
internal partial class Program
{
    private static void DisplayLetters(string letterInArgs)
    {
        char firstArg = Char.Parse(letterInArgs);

        for(char letter = 'a'; letter <= 'z'; letter++)
        {
            if(letter >= firstArg)
            {
                Console.Write(letter);
            }
        }
        Console.WriteLine("");
    }

    private static bool CheckIfOneArgsExists(string[] args)
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
        if(CheckIfOneArgsExists(args) && CheckIfThereIsOnlyOneLetter(args) && args[1].All(char.IsLetter))
        {
            DisplayLetters(args[1].ToLower());
        }
        else
        {
            Console.WriteLine("Tu dois entrer un unique argument avec un caractère valide (pas de chiffres ni caractères spéciaux)");
        }
    }
}