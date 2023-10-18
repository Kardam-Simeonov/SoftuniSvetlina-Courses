namespace Boom
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                        throw new ArgumentException("Boom");
                }
            }
            catch (Exception e)
            {
                Thread exceptionThread = new(() =>
                {
                    Console.WriteLine(e.Message);
                });

                exceptionThread.Start();
            }
        }
    }
}