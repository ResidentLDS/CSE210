class Program
{
    private static void Main()
    {
        int sleepTime = 250;
        int time = 9;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);
        // string animationString = "(°_°)(-_-)";
        string animationString2 = "x+";
        int count = time;
        int index = 0;
        while (DateTime.Now < endTime)
        {
            // Console.Write(animationString[0..5]);
            // Thread.Sleep(5000);
            // Console.Write("\b\b\b\b\b");
            // Console.Write(animationString[5..]);
            // Thread.Sleep(sleepTime);
            // Console.Write("\b\b\b\b\b");
            // Console.Write(animationString[0..5]);
            // Thread.Sleep(sleepTime);
            // Console.Write("\b\b\b\b\b");
            // Console.Write(animationString[5..]);
            // Thread.Sleep(sleepTime);
            // Console.Write("\b\b\b\b\b");

            // Console.Write(count--);
            // Thread.Sleep(1000);
            // Console.Write("\b");

            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");


        }
        Console.WriteLine("\nWho is the best character in ?");
    }
}