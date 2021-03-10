using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articleList = new List<Article>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                Article userArticle = new Article(input[0], input[1], input[2]);

                articleList.Add(userArticle);
            }

            string orderBy = Console.ReadLine();

            switch (orderBy)
            {
                case "title":
                    foreach (var article in articleList.OrderBy(x => x.Title))
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;

                case "content":
                    foreach (var article in articleList.OrderBy(x => x.Content))
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;

                case "Author":
                    foreach (var article in articleList.OrderBy(x => x.Author))
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
            }
            
            
        }
    }
}
