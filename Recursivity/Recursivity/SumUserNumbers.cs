public class SumUserNumbers
{
    public void Logic()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = Sum(number);

        Console.WriteLine("The result is: " + sum);
    }

    int Sum(int limit)
    {
        if (limit == 0)
            return limit;

        return limit + Sum(limit - 1);
    }
}



