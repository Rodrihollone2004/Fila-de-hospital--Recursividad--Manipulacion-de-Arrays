public class Pyramid
{
    public void Start()
    {
        Console.WriteLine("Write the height of the Pyramid: ");
        int height = int.Parse(Console.ReadLine());
        MakePyramid(height);
    }

    public void MakePyramid(int limit, int actual = 1)
    {
        if (actual > limit)
            return;

        int spaces = limit - actual;

        Console.Write(new string(' ', spaces));

        Console.WriteLine(new string('x', 2 * actual - 1));

        MakePyramid(limit, actual + 1);
    }
}

