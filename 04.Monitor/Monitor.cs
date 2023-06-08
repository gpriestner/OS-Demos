
public class Program
{ 
    private static int[] ar = new int [100];
    public static void Main()
    {
        var t1 = new Thread(Func);
        var t2 = new Thread(Func);
        var t3 = new Thread(Func);

        t1.Start();
        t2.Start();
        t3.Start();
    }
    public static void Func(object o)
    {
        Monitor.Enter(ar);
        Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} entered monitor");
        for (int i = 0; i < ar.Length; i++)
        {
            for (var c = 0; c < 10000000; ++c)
            {
                ar[i] += 1;
            }
        }
        Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} exited monitor");
        Monitor.Exit(ar);

        // lock
    }
}