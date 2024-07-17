using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //find the factorial of the given number
    internal class Problem8
    {
        
        static void Main()
        {
            int Factorial = 1;
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++) 
            {
                Factorial = Factorial * i;
            }
            Console.WriteLine(Factorial);
        }
    }
}
