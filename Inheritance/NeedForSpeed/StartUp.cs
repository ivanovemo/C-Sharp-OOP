using System;

namespace NeedForSpeed;

public class StartUp
{
    public static void Main(string[] args)
    {
        Car car = new(135, 45);
        Motorcycle motocycle = new(100, 25);
        RaceMotorcycle raceMotorcycle = new(100, 25);
        CrossMotorcycle crossMotorcycle = new(100, 25);

        raceMotorcycle.Drive(10);

        Console.WriteLine(raceMotorcycle.Fuel);
    }
}
