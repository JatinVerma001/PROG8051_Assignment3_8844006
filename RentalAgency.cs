using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment3_8844006
{
    public class RentalAgency
    {
        // Array to store instances of vehicles
        private Vehicle[] Fleet { get; set; }

        // Property to track total revenue earned by the rental agency
        public double TotalRevenue { get; private set; }

        // Constructor
        public RentalAgency(int fleetSize)
        {
            Fleet = new Vehicle[fleetSize];
            TotalRevenue = 0;
        }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle, int index)
        {
            if (index >= 0 && index < Fleet.Length)
            {
                Fleet[index] = vehicle;
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        // Method to remove vehicles from the fleet
        public void RemoveVehicle(int index)
        {
            if (index >= 0 && index < Fleet.Length)
            {
                Fleet[index] = null;
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        // Method to rent a vehicle
        public void RentVehicle(int index)
        {
            if (index >= 0 && index < Fleet.Length && Fleet[index] != null)
            {
                TotalRevenue += Fleet[index].RentalPrice;
                Fleet[index] = null;
                Console.WriteLine("Vehicle rented successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index or vehicle not available.");
            }
        }
    }
}
