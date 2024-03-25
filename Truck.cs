using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment3_8844006
{
    public class Truck : Vehicle
    {
        // Additional properties specific to trucks
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        // Constructor
        public Truck(string model, string manufacturer, int year, double rentalPrice, int capacity, string truckType, bool fourWheelDrive)
            : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Override method to display truck details
        public override void DisplayDetails()
        {
            Console.WriteLine($"\nThe deatils for Truck are given below:");
            Console.WriteLine($"--------------------------------------");
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
        }
    }
}
