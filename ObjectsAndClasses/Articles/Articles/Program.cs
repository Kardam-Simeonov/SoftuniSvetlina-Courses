using System;

namespace Articles
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article userArticle = new Article(input[0], input[1], input[2]);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= commands; i++)
            {
                string[] userCommand = Console.ReadLine().Split(": ");

                string method = userCommand[0];
                string methodContent = userCommand[1];

                switch (method)
                {
                    case "Edit":
                        userArticle.Edit(methodContent);
                        break;

                    case "ChangeAuthor":
                        userArticle.ChangeAuthor(methodContent);
                        break;

                    case "Rename":
                        userArticle.Rename(methodContent);
                        break;
                }
            }

            Console.WriteLine($"{userArticle.Title} - {userArticle.Content}: {userArticle.Author}");

        }
    }
}
