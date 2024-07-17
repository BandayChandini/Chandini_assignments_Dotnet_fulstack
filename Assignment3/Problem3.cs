using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /*3.Create a class called shapes Overload the Area method that has to calculate the area of rectangle, triangle, circle, and square by passing the relevant parameters.
     */

    class Shape()
    {
        double PI = 3.14;
        public void AreaOfRectangle(int i, int j)
        {
            Console.WriteLine($"Area of Rectangle is:{i * j}");
        }
        public void AreaOfCircle(int r)
        {
            Console.WriteLine($"Area of Circle is: {2 * PI * r}");
        }
        public void AreaOfTriangle(int i, int j)
        {
            Console.WriteLine($"Area of Triangle is: {0.5 * i * j}");
        }
        public void AreaOfSquare(int i)
        {
            Console.WriteLine($"Area of Square is: {i * i}");
        }
    }
    internal class Problem3
    {
        static void Main()
        {
            Shape area = new Shape();
            area.AreaOfTriangle(1, 2);
            area.AreaOfSquare(2);
            area.AreaOfCircle(5);
            area.AreaOfRectangle(4, 5);

        }
    }
}
