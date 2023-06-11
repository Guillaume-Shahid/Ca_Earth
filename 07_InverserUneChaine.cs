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
    private static void Main(string[] args)
    {   
        string outputString = "";

        if(CheckIfArgsExists(args))
        {
            try
            {
                string inputString = args[1];
            
                for(int i = (inputString.Length - 1); i >= 0; i--)
                {
                    outputString += inputString[i].ToString();
                }
                Console.WriteLine(outputString);
            }   
            catch
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