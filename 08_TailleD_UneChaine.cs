class Program
{
    private static bool CheckIfArgsExists(string[] args)
    {
        if(args.Length != 2)
        {
            return false;   
        }
        return true;
    }

    private static int numberOfCharInString(string inputString, int i)
    {
        try
        {
           if(inputString[i] != ' ')
            {
                i++;                
            }
            else
            {
               if(inputString[i+1] == ' ' || inputString[i+1] != ' ') 
               {
                i++;
               }
            }
        }
        catch
        {
            return i;
        }
        return numberOfCharInString(inputString,i);
    }

    private static void Main(string[] args)
    {
        if(CheckIfArgsExists(args))
        {
            string inputString = args[1];
            
            if(!double.TryParse(inputString, out _))
            {
                Console.WriteLine(numberOfCharInString(inputString,0));
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
}