using System;
using System.Collections.Generic;
using System.Text;

namespace VechicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(string userType, string userModel, string userColor, int userHorsePower)
        {
            Type = userType;
            Model = userModel;
            Color = userColor;
            HorsePower = userHorsePower;
        }
    }

    
}
