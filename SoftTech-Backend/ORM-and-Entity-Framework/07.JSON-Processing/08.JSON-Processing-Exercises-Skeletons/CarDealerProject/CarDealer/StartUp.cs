using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();

            Console.WriteLine(ImportSuppliers(context, "../../../Datasets/suppliers.json"));
            Console.WriteLine(ImportParts(context, "../../../Datasets/parts.json"));
            Console.WriteLine(ImportCars(context, "../../../Datasets/cars.json"));
            Console.WriteLine(ImportSales(context, "../../../Datasets/sales.json"));
            Console.WriteLine(GetOrderedCustomers(context));
        }
        public static string ImportSuppliers(CarDealerContext context, string input)
        {
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(input);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }
        public static string ImportParts(CarDealerContext context, string input)
        {
            var parts = JsonConvert.DeserializeObject<List<Part>>(input).ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }
        public static string ImportCars(CarDealerContext context, string input)
        {
            var cars = JsonConvert.DeserializeObject<List<Car>>(input);

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }
        public static string ImportSales(CarDealerContext context, string input)
        {
            var sales = JsonConvert.DeserializeObject<List<Sale>>(input);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";
        }
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(x => x.BirthDate)
                .ThenBy(x => x.IsYoungDriver)
                .Select(x => new
                {
                    Name = x.Name,
                    BirthDate = x.BirthDate.ToString("dd/MM/yyyy"),
                    IsYoungDriver = x.IsYoungDriver
                })
                .ToList();

            var json = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return json;
        }
    }
}