﻿//Write an expression that checks for given point (x, y) 
//if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

namespace PointInCircleOutRectangle
{
    using System;
    using System.Linq;
    class PointInCircleOutRectangle
    {
        const double radius = 5;
        const double xY = 1;
        static void Main(string[] args)
        {
            Console.Write("Enter the coordinates X and Y separated by a space. ");
            double[] coords = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Double.Parse(x))
                .ToArray();
            Console.WriteLine(IsInsideCircle(coords[0], coords[1]) && !IsOutsideRectangle(coords[0], coords[1]));
        }

        static bool IsInsideCircle(double x, double y)
        {
            return (Math.Pow((xY - x), 2) + Math.Pow((xY - y), 2) <= radius * radius);
        }

        static bool IsOutsideRectangle(double X, double Y)
        {
            //R(top=1, left=-1, width=6, height=2)

            double x1 = -1, x2 = 5, y1 = 1, y2 = 5;

            return !(X >= x1 && X <= x2 && Y >= y1 && Y <= y2);
        }
    }
}
