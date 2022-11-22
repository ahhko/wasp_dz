using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PassengerCar passengerCar1 =
                new PassengerCar("Ford", 200, 2008, 9, new Dictionary<string, int>() { });
            PassengerCar passengerCar2 =
                new PassengerCar("Сitroen", 250, 2018, 8, new Dictionary<string, int>() { });
            Truck truck1 = 
                new Truck("Mercedez", 500, 2010, 3000, "Фомин Глеб", new Dictionary<string, int>());
            Truck truck2 = 
                new Truck("КамАз", 600, 2020, 4000, "Фролов Егор", new Dictionary<string, int>());

            Autopark autopark;
            autopark = new Autopark("My Autopark", new List<Car>() {passengerCar1, passengerCar2, truck1, truck2});
            autopark.ToString();
        }
    }
    
}