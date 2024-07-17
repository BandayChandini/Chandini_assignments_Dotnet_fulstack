using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Write a program in C# to display temperature in Celsius.Accept the temperature in Fahrenheit.
    internal class Problem6
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature in Fahrenheit:");
            double Fahrenheit=double.Parse(Console.ReadLine());
            double Celsius= ((Fahrenheit-32)*5)/ 9;
            Console.WriteLine($"The temperature in celsius is:{Celsius}");
        }
    }
}
