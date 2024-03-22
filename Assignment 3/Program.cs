// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency(10);

        Car car1 = new Car("Civic", "Honda", 2022, 50.0, 5, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("F-150", "Ford", 2021, 100.0, 3, "Pickup", true);
        Motorcycle motorcycle1 = new Motorcycle("Ninja", "Kawasaki", 2020, 30.0, 1000, "Petrol", true);

        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(motorcycle1);

        Console.WriteLine("Details of Vehicles in Fleet:");
        foreach (var vehicle in agency.Fleet)
        {
            if (vehicle != null)    //Null was added
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Total Revenue: {agency.TotalRevenue}");
    }
}
