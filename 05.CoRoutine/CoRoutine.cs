namespace CoRoutine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Coroutine())
            {
                Console.WriteLine(i);
            }
        }

        public static IEnumerable<int> Coroutine()
        {
            yield return 10;
            yield return 2;
            yield return 13;
            yield return 94;
            yield return 57;
        }
    }
}