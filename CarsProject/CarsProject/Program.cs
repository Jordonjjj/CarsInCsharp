using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace CarsProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {  
        List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            // main menu
            // Prompt for user input, show menu until 4
            string input = "";

            while (input != "4")
            {
                Console.WriteLine("Welcome to Jeremy's Car Dealership, where your credit goes to die!");
                Console.WriteLine(" 1. Add a new car");
                Console.WriteLine(" 2. Sell a current car");
                Console.WriteLine(" 3. List all cars");
                Console.WriteLine(" 4. Quit");
                input = Console.ReadLine();
            }
        }
        public void AddCar()
        {
            Console.WriteLine("Enter the year of the vehicle:");
            Car car = new Car();
            int year = int.Parse(Console.ReadLine());
            car.year = year;
            Console.WriteLine("Enter the make of the vehicle:");
            string make = Console.ReadLine();
            car.make = make;
            Console.WriteLine("Enter the model of the vehicle:");
            string model = Console.ReadLine();
            car.model = model;
            Console.WriteLine("Enter the number of doors on the vehicle:");
            int numofDoors = int.Parse(Console.ReadLine());
            car.numberofDoors = numofDoors;
            Console.WriteLine("Enter the price of the vehicle:");
            double price = double.Parse(Console.ReadLine());
            car.price = price;
            cars.Add(car);
            Console.WriteLine("Your car is: " + car.year.ToString() + " " + car.make + " " + car.model);

        }

        public void DeleteCar()
        {

        }

        public void ListCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.year.ToString() + "" + car.make + "" + car.model + "" + car.price.ToString());
            }
        }

    }
}