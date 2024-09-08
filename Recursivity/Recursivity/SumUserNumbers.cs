public class SumUserNumbers
{
    public void Logic()
    {
        int number = 5;
        int sum = Sum(number);

        Console.WriteLine("Sum: " + sum);
    }

    int Sum(int limit)
    {
        if (limit == 0)
            return limit;

        return limit + Sum(limit - 1);
    }
}



