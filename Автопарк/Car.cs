using System;
using System.Collections.Generic;


namespace ConsoleApplication3
{
    public class Car
    {
        protected string _brand;
        protected int _power;
        protected int _year;

        public Car(string brand, int power, int year)
        {
            this._brand = brand;
            this._power = power;
            this._year = year;
        }

        public override string ToString()
        {
            return $"Brand: {_brand}\nPower: {_power}\nYear: {_year}";
        } 
        
    }
    public class PassengerCar : Car
    {
        private int _numofpass;
        public PassengerCar(string brand, int power, int year, int numofpass, Dictionary<string, int> book) :
            base(brand, power, year)
        {
            this._numofpass = numofpass;
        }
            
        Dictionary<string, int> _book = new Dictionary<string, int>();
        
        public void AddSparePart(string part, int year)
        {
            _book.Add(part, year);
        }

        public override string ToString()
        {
            return $"Brand: {_brand}\nPower: {_power}\nYear: {_year}\nNumber of passengers: {_numofpass}\n";
        }

        public int ReplacementYear(string name)
        {
            return _book[name];
        }

        public void Book()
        {
            foreach (var kvp in _book)
            {
                Console.WriteLine($"Name of spare part: {kvp.Key}  Replacement year: {kvp.Value}");
            }
        }
    }

    public class Truck : Car
    {
        private int _carrying;
        private string _fio;

        public Truck(string brand, int power, int year, int carrying, string fio, Dictionary<string, int> goods) :
            base(brand, power, year)
        {
            this._carrying = carrying;
            this._fio = fio;
        }

        Dictionary<string, int> _goods = new Dictionary<string, int>();

        public void ChangeDriver(string NewDriver)
        {
            this._fio = NewDriver;
        }
        
        public override string ToString()
        {
            return $"Brand: {_brand}\nPower: {_power}\nYear: {_year}\nCarrying: {_carrying}\nDriver: {_fio}\n";
        }

        public void AddGoods(string key_goods, int value_goods)
        {
            _goods.Add(key_goods, value_goods);
        }

        public void RemoveGoods(string key_goods)
        {
            _goods.Remove(key_goods);
        }
        
        public void Goods()
        {
            foreach (var kvp in _goods)
            {
                Console.WriteLine($"Name: {kvp.Key}  Weight: {kvp.Value}");
            }
        }
    }
}