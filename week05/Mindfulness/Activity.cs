abstract class Activity //I learn abstract on you tube as a substitute for base class 
{
    protected int duration;

    public abstract string GetName();
    public abstract string GetDescription();

    public void Start()
    {
        Console.Clear();
        Console.WriteLine(GetName());
        Console.WriteLine(GetDescription());
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin!");
        Pause(3);
        PerformActivity();
        EndActivity();
    }

    protected void EndActivity()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rPausing... {i} seconds remaining.");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();
}