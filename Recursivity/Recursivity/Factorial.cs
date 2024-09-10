public class Factorial
{
    public void Start(int number)
    {
        int res = Fact(number);

        Console.WriteLine("The result is: ");
        Console.Write(res);
    }

    int Fact(int limit)
    {
        if (limit <= 1)
            return limit;

        int res = limit * Fact(limit - 1);

        return res;
    }
}



