using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Assignment3
{
    /*1.Create a reference type called Person. Populate the Person class with the following attributes to store the following information:

    First name

    Last name

    Email address

    Date of birth

    Add constructors that accept the following parameter lists:

    All four parameters

    First name, Last name, Email

    First name, Last name, Date of birth

    Write appropriate methods to accept and display the details.
    */
    class Person
    {
        public string FirstName, LastName, EmailAddress;
        public DateTime DateOfBirth;
        public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            DateOfBirth = dateOfBirth;


        }
        public void Show()
        {
            Console.WriteLine($"firstName:{FirstName},lastName:{LastName},emailAddress:{EmailAddress},DateOfBirth:{DateOfBirth}");
        }
        public Person(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }
        public void Show1()
        {
            Console.WriteLine($"firstName:{FirstName},lastName:{LastName},emailAddress:{EmailAddress}");
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public void Show2()
        {
            Console.WriteLine($"firstName:{FirstName},lastName:{LastName},DateOfBirth:{DateOfBirth}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person data = new Person("chandini", "banday", "chandinibanday@gmail.com", new DateTime(2002, 04, 27));//Convert.ToDateTime("10/04/2002");
            Person data1 = new Person("chandini", "banday", "chandinibanday@gmail.com");
            Person data2 = new Person("chandini", "banday", Convert.ToDateTime("10/04/2022"));
            data.Show();
            data1.Show1();
            data2.Show2();


        }
    }
}
