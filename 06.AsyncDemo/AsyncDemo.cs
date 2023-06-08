public class Program
{
    public static void CP(int id) => Console.WriteLine($"CP{id}:{Environment.CurrentManagedThreadId}");
    public static async Task Main()
    {
        CP(1);
        Task<int> task = LongOperation();
        CP(3);
        // do other stuff
        int result = await task;
        CP(4);
        // do stuff here with return 
        Console.WriteLine(result);
    }

    public static async Task<int> LongOperation()
    {
        CP(2);
        // do stuff here 
        await Task.Delay(4000);
        CP(5);
        return 1;
    }
}