using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            car1.Year = 2012;
            car1.Make = "Lexus";
            car1.Model = "Lfa";
            car1.IsDriveable = true;
            car1.EngineNoise = "vroom";
            car1.HonkNoise = "beep";
            //Console.WriteLine($"My car is a {car1.Year} {car1.Make} {car1.Model} and it's {car1.IsDriveable} that it's driveable");
            //car1.MakeEngineNoise();
            //car1.MakeHonkNoise();

            Car car2 = new Car();
            car2.Year = 1995;
            car2.Make = "Chevy";
            car2.Model = "Silverado";
            car2.IsDriveable = false;
            car2.EngineNoise = "vroom";
            car2.HonkNoise = "beep";
            //Console.WriteLine($"My car is a {car2.Year} {car2.Make} {car2.Model} and it's {car2.IsDriveable} that it's driveable");
            //car2.MakeEngineNoise();
            //car2.MakeHonkNoise();

            //Car car3 = new Car();
            //car3.Year = 2016;
            //car3.Make = "Chevy";
            //car3.Model = "Duramax";
            //car3.IsDriveable = true;
            //car3.EngineNoise = "vrooom";
            //car3.HonkNoise = "beeeeeep";
            //Console.WriteLine($"My car is a {car3.Year} {car3.Make} {car3.Model} and it's {car3.IsDriveable} that it's driveable");
            //car3.MakeEngineNoise();
            //car3.MakeHonkNoise();
            Car car3 = new Car() //object initiliazer syntax
            {
                Year = 2020,
                Make = "Ford",
                Model = "F150",
                IsDriveable = true,
                EngineNoise = "vroom",
                HonkNoise = "beep"
            };

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot.ParkingLot = new List<Car>() { car1, car2, car3 };
            {
                foreach (var car in CarLot.ParkingLot )
                {
                    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                    car.MakeEngineNoise();
                    car.MakeHonkNoise();
                }
            }
        }
    }
}
