using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();
    public static int NumberOfCars;

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }
}