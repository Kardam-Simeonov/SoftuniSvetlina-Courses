using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.InterfacesAndClasses
{
    public interface ILaptop : IProduct
    {
        IReadOnlyCollection<IHardware> HardwareParts { get; }

        void AddHardware(IHardware hardwarePart);

    }
}
