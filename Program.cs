using PROG8051_Assignment3_8844006;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car1 = new Car("Camry", "Toyota", 2020, 50, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("F-150", "Ford", 2019, 70, 4, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2021, 40, 1000, "Gasoline", true);

        // Displaying vehicle details
        car1.DisplayDetails();
        truck1.DisplayDetails();
        bike1.DisplayDetails();

        // Creating a rental agency
        RentalAgency agency = new RentalAgency(10);

        // Adding vehicles to the fleet
        agency.AddVehicle(car1, 0);
        agency.AddVehicle(truck1, 1);
        agency.AddVehicle(bike1, 2);

        // Renting a vehicle
        agency.RentVehicle(1);

        // Displaying total revenue
        Console.WriteLine($"\n------------------------");
        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }
}
