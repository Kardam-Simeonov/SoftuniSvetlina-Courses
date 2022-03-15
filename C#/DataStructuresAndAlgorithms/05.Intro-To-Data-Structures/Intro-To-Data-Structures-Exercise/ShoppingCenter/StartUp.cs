using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Center
{
    public class StartUp
    {
        private static readonly ProductList ProductList = new ProductList();

        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var command = Console.ReadLine();
                ProcessCommand(command);
            }
        }

        private static void ProcessCommand(string input)
        {
            input = input.Trim();

            var index = input.IndexOf(' ');
            var command = input.Substring(0, index);

            input = input.Substring(index + 1);

            var args = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string result;

            switch (command)
            {
                case "AddProduct":
                    result = AddProduct(args);
                    break;
                case "DeleteProducts":
                    result = DeleteProducts(args);
                    break;
                case "FindProductsByName":
                    result = FindProductsByName(args);
                    break;
                case "FindProductsByProducer":
                    result = FindProductsByProducer(args);
                    break;
                case "FindProductsByPriceRange":
                    result = FindProductsByPriceRange(args);
                    break;
                default:
                    result = "Invalid Command";
                    break;
            }

            Console.WriteLine(result);
        }

        private static string FindProductsByPriceRange(string[] args)
        {
            Product[] foundProducts = ProductList.FindProductsByPriceRange(decimal.Parse(args[0]), decimal.Parse(args[1])).ToArray();

            if (foundProducts.Count() == 0)
                return "No products found";

            return ConcatenateProducts(foundProducts);
        }

        private static string FindProductsByProducer(string[] args)
        {
            Product[] foundProducts = ProductList.FindProductsProducer(args[0]).ToArray();

            if (foundProducts.Count() == 0)
                return "No products found";

            return ConcatenateProducts(foundProducts);
        }

        private static string FindProductsByName(string[] args)
        {
            Product[] foundProducts = ProductList.FindProductsByName(args[0]).ToArray();

            if (foundProducts.Count() == 0)
                return "No products found";

            return ConcatenateProducts(foundProducts);
        }

        private static string ConcatenateProducts(IEnumerable<Product> products)
        {
            return String.Join("\n", products);
        }

        private static string DeleteProducts(string[] args)
        {
            int deletedProducts;

            if (args.Length == 1)
                deletedProducts = ProductList.DeleteByProducer(args[0]);
            else
                deletedProducts = ProductList.DeleteByNameAndProducer(args[0], args[1]);

            return $"{(deletedProducts > 0 ? deletedProducts.ToString() : "No")} products deleted";
        }

        private static string AddProduct(string[] args)
        {
            ProductList.AddProduct(args[0], decimal.Parse(args[1]), args[2]);
            return "Product added";
        }
    }
}
