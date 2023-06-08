public class Program
{
    public static void Main()
    {
        var t1 = new Thread(fn);
        t1.IsBackground = true;

        t1.Start();

        Thread.Sleep(5000); //t1.Join();

        Console.WriteLine("Main thread finishing");
    }

    public static void fn()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(400);
        }
    }
}