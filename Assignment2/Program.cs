using System.Diagnostics;

namespace Assignment2
{
    
    internal class Program
    {
        static void Main()
           
        {
            double balance = 1000.0;
            double monthlyInterestRate = 0.015;
            double monthlyPayment;
            double totalPayments = 0.0;
            
            int month = 1;

            Console.Write("Enter the monthly payment: ");
            monthlyPayment = double.Parse(Console.ReadLine());
            while (balance > 0)
            {
                balance = balance + (balance * monthlyInterestRate);
                balance = balance - monthlyPayment;
                if (balance < 0)
                {
                    balance = 0;
                }
                totalPayments += monthlyPayment;
                Console.WriteLine($"Month:{month} balance:{balance:F2} payment:{totalPayments:F2}");
                month++;
            }
        }
    }
 }