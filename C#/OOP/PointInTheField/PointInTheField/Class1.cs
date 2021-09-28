using System;
using System.Collections.Generic;
using System.Text;

namespace PointInTheField
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }


        public Point(string name, double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format($"{this.Name}({X:F2}, {Y:F2})");
        }
    }
}
