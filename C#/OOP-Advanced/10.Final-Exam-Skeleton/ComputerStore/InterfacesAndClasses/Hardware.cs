using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public class Hardware : Product, IHardware
    {
        private int _generation;

        public int Generation { get => _generation; set => _generation = value; }

        public Hardware(int id, string model, decimal price, double overallPerformance, int generation) : base(id, model, price, overallPerformance)
        {
            this.Generation = generation;
        }

        public override string ToString()
        {
            return $"Model: {this.Model} with: Overall Performance: {this.OverallPerformance}. Price: {this.Price} (Id: {this.Id}) Generation: {this.Generation}";
        }
    }
}
