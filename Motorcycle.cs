using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment3_8844006
{
    public class Motorcycle : Vehicle
    {
        // Additional properties specific to motorcycles
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        // Constructor
        public Motorcycle(string model, string manufacturer, int year, double rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
            : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        // Override method to display motorcycle details
        public override void DisplayDetails()
        {
            Console.WriteLine($"\nThe deatils for MotorCycle are given below:");
            Console.WriteLine($"-------------------------------------------");
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity}, Fuel Type: {FuelType}, Has Fairing: {(HasFairing ? "Yes" : "No")}");
        }
    }
}
