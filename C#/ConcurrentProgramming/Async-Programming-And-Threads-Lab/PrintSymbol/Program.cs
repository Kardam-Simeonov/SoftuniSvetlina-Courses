namespace PrintSymbol
{
    class Program
    {
        public static void Main(string[] args)
        {
            Thread printThread = new Thread(() => Go('O'));
            printThread.Start();

            Go('X');
        }
        static void Go(char symbol)
        {
            for (int i = 0; i < 450; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}