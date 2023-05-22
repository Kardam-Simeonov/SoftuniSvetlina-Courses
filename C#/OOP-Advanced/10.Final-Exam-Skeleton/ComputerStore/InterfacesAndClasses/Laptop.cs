using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public abstract class Laptop : ILaptop
    {
        private List<IHardware> _hardwareParts = new List<IHardware>();
        private int _id;
        private string _model;
        private decimal _price;
        private double _overallPerformance;

        public IReadOnlyCollection<IHardware> HardwareParts => this._hardwareParts.AsReadOnly();

        public int Id { get => this._id; set => this._id = value; }

        public string Model { get => this._model; set => this._model = value; }

        public decimal Price
        {
            get => this.HardwareParts.Sum(h => h.Price) + this._price;
            set => this._price = value;
        }

        public double OverallPerformance
        {
            get
            {
                double hardwareAvg = 0.0;

                if (HardwareParts.Count > 0)
                {
                    hardwareAvg = HardwareParts.Average(h => h.OverallPerformance);
                }

                return _overallPerformance + hardwareAvg;
            }
            set => this._overallPerformance = value;
        }

        public Laptop(int id, string model, decimal price, double overallPerformance)
        {
            this.Id = id;
            this.Model = model;
            this.Price = price;
            this.OverallPerformance = overallPerformance;
        }

        public void AddHardware(IHardware hardwarePart)
        {
            if (this.HardwareParts.Any(h => h.GetType() == hardwarePart.GetType()))
            {
                throw new ArgumentException($"Hardware part with Id {hardwarePart.Id} is already added.");
            }

            this._hardwareParts.Add(hardwarePart);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Model: {this.Model} with: Overall Performance: {this.OverallPerformance}. Price: {this.Price} (Id: {this.Id})");
            sb.AppendLine($" Hardware ({this.HardwareParts.Count}):");
            foreach (var hardwarePart in HardwareParts)
            {
                sb.AppendLine($"  {hardwarePart.ToString()}");
            }

            return sb.ToString();
        }
    }
}
