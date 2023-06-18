using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public class TraditionalLaptop : Laptop
    {
        public TraditionalLaptop(int id, string model, decimal price) : base(id, model, price, 20)
        {
        }
    }
}
