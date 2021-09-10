using System;

namespace PointInTheField
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/
            Point[] points = new Point[5];

            points[0] = new Point("A", 2, 3);
            points[1] = new Point("B", 3, 6);
            points[2] = new Point("C", 54, 5);
            points[3] = new Point("D", 6, 6);
            points[4] = new Point("E", 23, 5);

            double maxDistance = double.MinValue;

            for (int i = 1; i < points.Length; i++)
            {
                double currentDistance = Distance(points[0], points[i]);

                if (currentDistance > maxDistance)
                    maxDistance = currentDistance;
            }

            Console.WriteLine(maxDistance);
            /*/



        }

        static double Distance(Point A, Point B)
        {
            double distance = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));

            return Math.Abs(distance);
        }

        static bool IsInside(Circle circle, Point point)
        {
            if (Distance(circle.Center, point) <= circle.Radius)
                return true;
            else
                return false;
        }
    }
}
