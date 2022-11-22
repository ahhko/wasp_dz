using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class Autopark
    {
        private string _autoparkName;
        private List<Car> _cars = new List<Car>();

        public Autopark(string autoparkName, List<Car> cars)
        {
            this._autoparkName = autoparkName;
            this._cars = cars;
        }

        public override string ToString()
        {
            Console.WriteLine($"Autopark name: {_autoparkName}\n");
            foreach (Car CarFromAutopark in _cars)
            {
                Console.WriteLine(CarFromAutopark.ToString());

            }

            return null;
        }
    }
}