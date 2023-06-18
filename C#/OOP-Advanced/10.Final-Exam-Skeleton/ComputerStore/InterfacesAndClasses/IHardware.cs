using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public interface IHardware : IProduct
    {
        int Generation { get; }
    }
}
