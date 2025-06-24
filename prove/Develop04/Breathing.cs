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
        Console.Write("Breathe in..."); BreathingFace(1, 4);
        Console.WriteLine();
        Console.Write($"Breath Out...");
        if (waitTime % 10 == 9)
        {
            BreathingFace(2,5);
        }
        else
        {
            BreathingFace(2,4);
        }
        Console.WriteLine();
        for (int i = 0; i < _timesThrough; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in..."); BreathingFace(1, 4);
            Console.WriteLine();
            Console.Write($"Breath Out..."); BreathingFace(2, 6); //So I accidentally backspaced a few too many times, saw it move here, it wasn't red, the code ran like intended, left it
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private void BreathingFace(int inorout, int _seconds)
    {
        string face = "(°o°)(°O°)(-O-)(-o-)";
        DateTime currentTime = DateTime.Now;
        DateTime _endTime = currentTime.AddSeconds(_seconds);
        while (DateTime.Now < _endTime)
        {
            if (inorout == 1)
            {
                Console.Write(face[0..5]);
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b");
                Console.Write(face[5..10]);
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b");
            }
            else
            {
                Console.Write(face[10..15]);
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b");
                Console.Write(face[15..20]);
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b");
            }
        }
        Console.Write("     ");
    }
}