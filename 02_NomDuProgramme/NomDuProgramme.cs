using System;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        string path = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
        string[] pathSplited = path.Split('/');
        Console.WriteLine(pathSplited[(pathSplited.Length - 1)]);
    }
}