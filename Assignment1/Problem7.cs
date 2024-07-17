using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Write a program to print the series :0,1,4,9,16,25...625
    internal class Problem7
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int num=int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.Write(i * i);
                if (i < num)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
