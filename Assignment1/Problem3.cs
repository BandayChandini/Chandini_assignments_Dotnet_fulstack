using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Write a program in C# to accept two numbers as command line arguement and display all the numbers between the given two numbers
    internal class Problem3
    {
        static void Main()
        {
            Console.Write("Enter input1:");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Enter input1:");
            int input2 = int.Parse(Console.ReadLine());
            for (int i=input1+1; i < input2; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
