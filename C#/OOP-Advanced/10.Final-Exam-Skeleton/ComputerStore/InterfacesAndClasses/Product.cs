using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public abstract class Product : IProduct
    {
        private int _id;
        private string _model;
        private decimal _price;
        private double _overallPerformance;

        public int Id { get => this._id; set { if (value <= 0) { throw new ArgumentException("The Id is not allowed to be zero or less."); } this._id = value; } }
        public string Model { get => this._model; set => this._model = value; }
        public decimal Price { get => this._price; set => this._price = value; }
        public double OverallPerformance { get => this._overallPerformance; set => this._overallPerformance = value; }

        public Product(int id, string model, decimal price, double overallPerformance)
        {
            this.Id = id;
            this.Model = model;
            this.Price = price;
            this.OverallPerformance = overallPerformance;
        }

        public override string ToString()
        {
            return $"Overall Performance: {this._overallPerformance}. Price: {this._price}: (Id: {this._id})";
        }
    }
}
