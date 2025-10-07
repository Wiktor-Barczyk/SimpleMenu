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
            try
            {
                int.Parse(Choice);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.WriteLine();
                continue;
            }
            int NChoice = int.Parse(Choice);
            Console.WriteLine();

            if (NChoice == 1)
            {
                Vehicle Car = new Car();
                Console.Write("Enter the car brand: ");
                Car.Brand = Console.ReadLine();
                Console.Write("Enter the car model: ");
                Car.Model = Console.ReadLine();
                Console.Write("Enter year of manufacture: ");
                Car.Year = int.Parse(Console.ReadLine());
                pojazd.Add(Car);
                Console.Clear();
            }
            else if (NChoice == 2)
            {
                Vehicle Bicycle = new Bicycle();
                Console.Write("Enter the brand of your bicycle: ");
                Bicycle.Brand = Console.ReadLine();
                Console.Write("Enter the model of your bicycle: ");
                Bicycle.Model = Console.ReadLine();
                Console.Write("Enter year of manufacture: ");
                Bicycle.Year = int.Parse(Console.ReadLine());
                pojazd.Add(Bicycle);
                Console.Clear();
            }
            else if (NChoice == 3)
            {
                foreach (var p in pojazd)
                {
                    p.DisplayInfo();
                    p.Start();
                    Console.WriteLine();
                }
            }
            else if (NChoice == 4)
            {
                break;
            }
        }
    }
}
