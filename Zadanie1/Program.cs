using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(Brand);
        Console.WriteLine(Model);
        Console.WriteLine(Year);
    }
    public abstract void Start();

}
public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Starting the engine...");
    }
}

public class Bicycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Starting to pedal...");
    }
}
class Program
{
    static void Main()
    {
        List<Vehicle> pojazd = new List<Vehicle>();

        while (true)
        {
            Console.WriteLine("1.Add a Car");
            Console.WriteLine("2.Add a Bicycle");
            Console.WriteLine("3.Display all Vehicles");
            Console.WriteLine("4.Exit");
            Console.Write("Enter your choice: ");
            string Choice = Console.ReadLine();
            int FChoice = int.Parse(Choice);
            Console.WriteLine();

            if (FChoice == 1)
            {
                Vehicle Car = new Car();
                Console.Write("Podaj marke samochodu: ");
                Car.Brand = Console.ReadLine();
                Console.Write("Podaj model samochodu: ");
                Car.Model = Console.ReadLine();
                Console.Write("Podaj rok produkcji samochodu: ");
                Car.Year = int.Parse(Console.ReadLine());
                pojazd.Add(Car);
                Console.Clear();
            }
            else if (FChoice == 2)
            {
                Vehicle Bicycle = new Bicycle();
                Console.Write("Podaj marke roweru: ");
                Bicycle.Brand = Console.ReadLine();
                Console.Write("Podaj model roweru: ");
                Bicycle.Model = Console.ReadLine();
                Console.Write("Podaj rok produkcji roweru: ");
                Bicycle.Year = int.Parse(Console.ReadLine());
                pojazd.Add(Bicycle);
                Console.Clear();
            }
            else if (FChoice == 3)
            {
                foreach (var p in pojazd)
                {
                    p.DisplayInfo();
                    p.Start();
                    Console.WriteLine();
                }
            }
            else if (FChoice == 4)
            {
                break;
            }
        }
    }
}
