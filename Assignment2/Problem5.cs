using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Shapes
    {
        // Method to calculate the area of a rectangle
        public double Area(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a triangle
        public double Area(double baselength, double height, bool isTriangle)
        {
            return 0.5 * baselength * height;
        }

        // Method to calculate the area of a circle
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the area of a square
        public double Area(double side, bool isSquare)
        {
            return side * side;
        }
    }

    public class Assignment5
    {
        public static void Main(string[] args)
        {
            Shapes shapes = new Shapes();

            // Calculate and display area of rectangle
            double rectangleLength = 10;
            double rectangleWidth = 5;
            double rectangleArea = shapes.Area(rectangleLength, rectangleWidth);
            Console.WriteLine($"Area of Rectangle (Length: {rectangleLength}, Width: {rectangleWidth}): {rectangleArea}");

            // Calculate and display area of triangle
            double triangleBaselength = 10;
            double triangleHeight = 5;
            double triangleArea = shapes.Area(triangleBaselength, triangleHeight);
            Console.WriteLine($"Area of Triangle (Base: {triangleBaselength}, Height: {triangleHeight}): {triangleArea}");

            // Calculate and display area of circle
            double circleRadius = 5;
            double circleArea = shapes.Area(circleRadius);
            Console.WriteLine($"Area of Circle (Radius: {circleRadius}): {circleArea}");

            // Calculate and display area of square
            double squareSide = 4;
            double squareArea = shapes.Area(squareSide, true);
            Console.WriteLine($"Area of Square (Side: {squareSide}): {squareArea}");
        }
    }
}
