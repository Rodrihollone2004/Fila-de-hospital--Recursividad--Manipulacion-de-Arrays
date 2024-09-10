public class Fibonacci
{
    int last = 0;
    int current = 1;

    public int FibonacciFunction(int limit)
    {
        if (limit <= 1)
            return limit;

        int result = Add(last, current);

        last = current;
        current = result;
        Console.WriteLine("Fibonacci: " + result);

        return FibonacciFunction(limit - 1);
    }

    int Add(int last, int current)
    {
        int result = last + current;
        return result;
    }
}

