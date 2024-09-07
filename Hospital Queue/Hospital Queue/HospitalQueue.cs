public class HospitalQueue
{
    Random random;
    int priority = 0;
    PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

    public void Queue()
    {
        for (int i = 0; i < 20; i++)
        {
            random = new Random();
            priority = random.Next(1, 4);
            string name = $"Pacient: {i} -- Priority: {priority}";
            priorityQueue.Enqueue(name, priority);
        }

        while (priorityQueue.Count > 0)
        {
            string pacient = priorityQueue.Dequeue();
            Console.WriteLine(pacient);
        }
    }
}
