using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    class Accounts
    {
        public long Ano;
        public string name;
        public string acctype;
        public int balance;
        public int credit(int camount)
        {
            balance = balance + camount;
            return balance;
        }
        public int debit(int damount)
        {
            balance = balance - damount;
            return balance;
        }
        public void Accept()
        {
            Console.WriteLine($"Ano={Ano} name={name} acctype{acctype}");

        }
        public void Display()
        {
            Console.WriteLine($"AccountNumber { Ano} Name{name} AccType {acctype} balance{balance}");
        }
        static void Main()
        {
            Accounts ob = new Accounts();
            Console.WriteLine("enter the account number: ");
            ob.Ano = long.Parse(Console.ReadLine());
            Console.WriteLine("enter the account name: ");
            ob.name = Console.ReadLine();
            Console.WriteLine("enter the acc type: ");
            ob.acctype = Console.ReadLine();
            Console.WriteLine("enter the balance: ");
            ob.balance = int.Parse(Console.ReadLine());
            

            do
            {
                Console.WriteLine("Enter the type of transaction");
                Console.WriteLine("1.Deposit\n2.Withdraw \n 3.Exit");
                int transtype = int.Parse(Console.ReadLine());
                switch (transtype)
                {
                    case 1:
                        {
                            Console.WriteLine("enter the amount to deposite: ");
                            int Amount=ob.credit(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("total amount after deposite:" + Amount);
                          
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter amount to withdraw");
                            Console.WriteLine("The avail balance after deposit is " + ob.debit(int.Parse(Console.ReadLine())));
                          
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine ("invalid input");
                                break;
                        }
                }
            } while (true);
           
        }
        
    }
}