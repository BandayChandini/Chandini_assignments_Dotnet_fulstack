using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /*Create a class called building which has datamembers like

    string type(Flat/Villa)

    string capacity(2BHK/3BHK/4BHK)

    string dimension

    if flat store the floor number where the flat is available

    If villa store the land dimension like 20X30,60X40,30X40 as values

    string dateofcompletion

    Accept all values through constructor

    Display all values using showdata().
    */
    class Building
    {
        public string type, capacity, dimension, landDimension, floorNumber, additionalInfo, dateofCompletion;

        public Building(string type, string capacity, string dimension, string additionalInfo, string dateofCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.additionalInfo = additionalInfo;
            this.dateofCompletion = dateofCompletion;

        }
        public void ShowData()
        {
            if (type.ToLower() == "flat")
            {
                this.floorNumber = additionalInfo;
                this.landDimension = "Not Applicable";
            }
            else if (type.ToLower() == "villa")
            {
                this.landDimension = additionalInfo;
                this.floorNumber = "Not Applicable";

            }
            else
            {
                Console.WriteLine("Type must be either 'flat' or 'villa'");
            }
            Console.WriteLine($"Type:{type}");
            Console.WriteLine($"Capacity:{capacity}");
            Console.WriteLine($"Land Dimension:{landDimension}");
            Console.WriteLine($"Floor Number:{floorNumber}");
            Console.WriteLine($"Date of Completion:{dateofCompletion}");

        }
        public static void Main()
        {
            Building b = new Building("flat", "3BHK", "1500 sq ft", "5th floor", "27/04/2002");
            Building b1 = new Building("villa", "4BHK", "1400 sq ft", "800* 200", "27/05/2021");
            Console.WriteLine("Flat Details:");
            b.ShowData();
            Console.WriteLine("Villa Details:");
            b1.ShowData();
        }
    }
}

