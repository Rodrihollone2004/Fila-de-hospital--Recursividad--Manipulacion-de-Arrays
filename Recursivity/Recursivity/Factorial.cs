public class Factorial
{
    public void Start()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int res = Fact(number);

        Console.WriteLine("The result is: ");
        Console.Write(res);
    }

    int Fact(int limit)
    {
        if (limit <= 1)
            return limit;

        return limit * Fact(limit - 1);
    }
}


