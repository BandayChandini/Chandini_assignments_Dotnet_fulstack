using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class problem2
    {
        /*Write a program in C# to accept the name of the user as a Command Line arguement and greet the user as :"Hi! username
        Welcome to the world of C#
        */
        static void Main()
        {
            Console.WriteLine("Enter username:");
            String s = Console.ReadLine();
            Console.WriteLine($"Hi! {s}");
            Console.WriteLine("Welcome to the world of C#");
            
        }
    }
}
