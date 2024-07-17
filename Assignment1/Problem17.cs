using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //accept the word from the user and display the reverse of it.
    internal class Problem17
    {
        static void Main()
        {
            Console.WriteLine("Enter the word: ");
            string s=Console.ReadLine();
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            string s1=new string(chars);
            Console.WriteLine(s1);

        }
    }
}
