
using System.Diagnostics.Metrics;

internal class Program
{
    static void Main(string[] args)
    {
        Arrays array = new Arrays();

        Console.WriteLine("Introduzca una oración: ");
        string word = Console.ReadLine();
        array.Start(word);
    }
}
