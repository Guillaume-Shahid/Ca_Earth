internal partial class Program
{
    private static void Main(string[] args)
    {
        for(int i = 1; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }
}