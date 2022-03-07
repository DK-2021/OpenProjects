using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_MSSA
{
    public class Vehicle
    {
        public string Vin { get; set; }
        public int Year { get; set; }
        public double Miles { get; set; }
        public string Makes { get; set; }
        public string  Model { get; set; }

        public Vehicle()
        {
            // Default constructor
        }
        public Vehicle(string vinNumber, int vehicleYear, double vehicleMiles, string vehicleMake, string vehicleModel)
        {
            Vin = vinNumber;
            Year = vehicleYear;
            Miles = vehicleMiles;
            Makes = vehicleMake;
            Model = vehicleModel;
        }
        public override string ToString() // This is an override method
        {
            return base.ToString(); // This is returning the base class/method function
        }
    }
    public class Car : Vehicle // This is how you inherit. Car class inherits (is a) Vehicle class.
    {
        public bool IsConvertible { get; set; }
        public Car()
        {
            // Default constructor
        }
        public Car(string vinNumber, int vehicleYear, double vehicleMiles, string vehicleMake, string vehicleModel, bool isConvertible) // Constructor
        {
            Vin = vinNumber;
            Year = vehicleYear;
            Miles = vehicleMiles;
            Makes = vehicleMake;
            Model = vehicleModel;
            IsConvertible = isConvertible; // This is specific to the Car class as it was added here and not inherited from the Vehicle (base) class.
        }
        public override string ToString()
        {
            string starter = base.ToString();
            return $"{starter}\tIs Convertible: {IsConvertible}";
        }
    }
}
