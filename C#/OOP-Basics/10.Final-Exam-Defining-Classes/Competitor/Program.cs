using System;

namespace ImplementCompetitor
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Competitor<int> IvanTheWiner = new Competitor<int>("Ivan", 16);
            Competitor<int> Vanya = new Competitor<int>("Vanya", 17);
            IvanTheWiner.Add(6);
            IvanTheWiner.Add(2);
            IvanTheWiner.Add(5);
            IvanTheWiner.Add(4);
            Console.WriteLine(IvanTheWiner.CompareTo(Vanya));
        }
    }
}
