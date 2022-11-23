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
    }
}