using System;
using System.Collections.Generic;
using System.Text;

namespace PointInTheField
{
    class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
        public string Name { get; set; }



        public override string ToString()
        {
            return string.Format($"{Name}({Center}, {Radius})");
        }
    }
}
