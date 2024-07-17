using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Write a program in C# to find the total number of odd and even numbers accepted from the user.
    internal class Problem5
    {
        static void Main()
        {
            Console.WriteLine("Enter the input:");
            int[] input = new int[10];
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"input[{i}]");
                input[i] = Convert.ToInt16(Console.ReadLine());
            }
            int Count = 0,Count1=0;
            for (int i=0; i < input.Length; i++) 
            {
                if (input[i] % 2 == 0)
                {
                    Count++;
                }
                else
                {
                    Count1++;
                }
            }
            Console.WriteLine("Total Even Numbers:" + Count);
            Console.WriteLine("Total Odd Numbers:" + Count1);
            Console.WriteLine();

        }
        
    }
}
