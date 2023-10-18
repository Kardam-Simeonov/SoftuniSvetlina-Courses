namespace ForwardAndBack
{
    class Program
    {
        public static List<char> chars = new () { 'o', 'o', 'x', 'o', 'o'};
        public static void Main(string[] args)
        {
            Thread threadA = new Thread(Forward);
            threadA.Start();

            Thread threadB = new Thread(Back);
            threadB.Start();

            threadA.Join();
            threadB.Join();
        }
        private static void Forward()
        {
            Thread.Sleep(500);
            chars[4] = 'f';
            Console.WriteLine(string.Join(" ", chars));
        }
        private static void Back()
        {
            Thread.Sleep(100);
            chars[4] = 'o';
            chars[4] = 'b';
            Console.WriteLine(string.Join(" ", chars));
        }
    }
}