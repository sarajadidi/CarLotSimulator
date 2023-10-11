using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var carlot = new CarLot();


            var charger = new Car();

            charger.Make = "Dodge";
            charger.Model = "Charger";
            charger.Year = 2000;
            charger.EngineNoise = "Vroom";
            charger.HonkNoise = "beep Beep";
            charger.IsDrivable = true;

            carlot.ParkingLot.Add(charger);


            //object initalizer

            var honda = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2021,
                EngineNoise = "rumble",
                HonkNoise = "beep",
                IsDrivable = true

            };
            carlot.ParkingLot.Add(honda);

            var camry = new Car(2001, "Toyota", "Camry", "Skrat", "beep beep", false);
            carlot.ParkingLot.Add(camry);

            //*************BONUS X 2*************//

            
            carlot.CheckCars();

            Console.WriteLine($"Number of cars on the lot: {CarLot.numberOfCars}");
        }

        
    }
}
