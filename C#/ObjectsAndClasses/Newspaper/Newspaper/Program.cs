using System;

namespace Newspaper
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] intialNews = Console.ReadLine().Split(", ");
            News theNews = new News(intialNews[0], intialNews[1], intialNews[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] newsChange = Console.ReadLine().Split(": ");

                switch (newsChange[0])
                {
                    case "Edit":
                        theNews.Edit(newsChange[1]);
                        break;
                    case "ChangeWriter":
                        theNews.ChangeWriter(newsChange[1]);
                        break;
                    case "Rename":
                        theNews.Rename(newsChange[1]);
                        break;
                }
            }

            Console.WriteLine(theNews);
        }
    }
}
