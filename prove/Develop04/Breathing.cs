class Breathing : Activity
{
    public Breathing()
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {
    }
    public void BreathingActivity()
    {
        int _timesThrough = waitTime / 10;
        InAndOutBurger(_timesThrough);
        ReturnCongrats();
    }

    private void InAndOutBurger(int _timesThrough)
    {
        Console.WriteLine();
        Console.Write("Breathe in..."); PrintCounter(4);
        Console.WriteLine();
        Console.Write($"Breath Out...");
        if (waitTime % 10 == 9)
        {
            PrintCounter(5);
        }
        else
        {
            PrintCounter(4);
        }
        Console.WriteLine();
        for (int i = 0; i < _timesThrough; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in..."); PrintCounter(4);
            Console.WriteLine();
            Console.Write($"Breath Out..."); PrintCounter(6); //So I accidentally backspaced a few too many times, saw it move here, it wasn't red, the code ran like intended, left it
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private void BreathingFace()
    {
        
    }
}