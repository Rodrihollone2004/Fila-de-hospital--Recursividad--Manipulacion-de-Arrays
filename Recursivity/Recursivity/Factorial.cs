public class Factorial
{
    public void Start()
    {
        int limit = 5;
        int res = Fact(limit);

        Console.Write(res);
    }

    int Fact(int num)
    {
        if (num <= 1)
            return num;

        int res = num * Fact(num - 1);

        return res;
    }
}



