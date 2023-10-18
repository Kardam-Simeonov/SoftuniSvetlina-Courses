namespace EvenNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            Thread printThread = new Thread(() =>
            {
                PrintEvenNumbers(start, finish);
            });
            printThread.Start();
            printThread.Join();
            Console.WriteLine("Thread finished work");
        }
        private static void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}