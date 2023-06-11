class Program
{
    private static bool CheckIfTwoArgsExists(string[] args)
    {
        if (args.Length != 3)
        {
            return false;
        }

        return true;
    }

    private static int Number1PowNumber2(int number1, int number2)
    {
        int result = 1;

        if (number2 != 0)
        {
            for (int i = 0; i < number2; i++)
            {
                if ((result * number1)/number1 == result)
                {
                    result *= number1;
                }
                else
                {
                    return -1;
                }
            }
        }

        return result;
    }

    private static void Main(string[] args)
    {
        if (CheckIfTwoArgsExists(args))
        {
            try
            {
                int number1 = Int32.Parse(args[1]);
                int number2 = Int32.Parse(args[2]);

                int result = Number1PowNumber2(number1, number2);

                if (result != -1)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Ton nombre est trop grand pour moi...");
                }
            }
            catch
            {
                Console.WriteLine("Tu dois rentrer des entiers !");
            }
        }
        else
        {
            Console.WriteLine("tu dois indiquer deux nombres entiers en arguments");
        }
    }
}
