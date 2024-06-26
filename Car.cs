﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment3_8844006
{
    public class Car : Vehicle
    {
        // Additional properties specific to cars
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }

        // Constructor
        public Car(string model, string manufacturer, int year, double rentalPrice, int seats, string engineType, string transmission, bool convertible)
            : base(model, manufacturer, year, rentalPrice)
        {
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }

        // Override method to display car details
        public override void DisplayDetails()
        {
            Console.WriteLine($"The deatils for Car are given below:");
            Console.WriteLine($"------------------------------------");
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {(Convertible ? "Yes" : "No")}");
        }
    }
}
