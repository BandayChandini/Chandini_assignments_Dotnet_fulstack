using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Accept a number from the user and display whether the given number is an even number or odd number
    internal class Problem4
    {
        static void Main()
        {
            Console.WriteLine("Enter a number1:");
            int input1 = int.Parse(Console.ReadLine());
            if (input1 % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
