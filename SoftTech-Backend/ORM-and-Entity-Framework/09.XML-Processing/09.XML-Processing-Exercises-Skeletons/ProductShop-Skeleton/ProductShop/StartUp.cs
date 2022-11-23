using ProductShop.Data;
using ProductShop.Models;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

        }
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var users = XDocument.Load(inputXml).Root.Elements().ToList().Cast<User>();
            context.Users.AddRange(users);
            return $"Successfully imported {users.Count()}"; 
        }
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var products = XDocument.Load(inputXml).Root.Elements().ToList().Cast<Product>();
            context.Products.AddRange(products);
            return $"Successfully imported {products.Count()}";
        }
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var categories = XDocument.Load(inputXml).Root.Elements().ToList().Cast<Category>();
            context.Categories.AddRange(categories);
            return $"Successfully imported {categories.Count()}";
        }
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var categoryProducts = XDocument.Load(inputXml).Root.Elements().ToList().Cast<CategoryProduct>();
            context.CategoryProducts.AddRange(categoryProducts);
            return $"Successfully imported {categoryProducts.Count()}";
        }
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    buyer = p.Buyer.FirstName + ' ' + p.Buyer.LastName
                })
                .ToList();

            XmlSerializer xmlSerializer = new XmlSerializer(products.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, products);
                return textWriter.ToString();
            }
        }
        public static string GetSoldProducts(ProductShopContext context)
        {   
            var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                    .Where(p => p.Buyer != null)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buyerFirstName = p.Buyer.FirstName,
                        buyerLastName = p.Buyer.LastName
                    })
                    .ToList()
                })
                .ToList();

            XmlSerializer xmlSerializer = new XmlSerializer(users.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, users);
                return textWriter.ToString();
            }
            
        }
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .OrderByDescending(c => c.CategoryProducts.Count)
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoryProducts.Count,
                    averagePrice = c.CategoryProducts.Average(cp => cp.Product.Price).ToString("F2"),
                    totalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price).ToString("F2")
                })
                .ToList();

            XmlSerializer xmlSerializer = new XmlSerializer(categories.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, categories);
                return textWriter.ToString();
            }
        }
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .OrderByDescending(u => u.ProductsSold.Count(p => p.Buyer != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = new
                    {
                        count = u.ProductsSold.Count(p => p.Buyer != null),
                        products = u.ProductsSold
                        .Where(p => p.Buyer != null)
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                        .ToList()
                    }
                })
                .ToList();

            var result = new
            {
                usersCount = users.Count,
                users = users
            };

            XmlSerializer xmlSerializer = new XmlSerializer(result.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, result);
                return textWriter.ToString();
            }
        }
    }
}