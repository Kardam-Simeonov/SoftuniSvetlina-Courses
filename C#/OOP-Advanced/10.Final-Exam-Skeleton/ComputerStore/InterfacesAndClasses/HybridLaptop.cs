using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public class HybridLaptop : Laptop
    {
        public HybridLaptop(int id, string model, decimal price) : base(id, model, price, 15)
        {
        }
    }
}
