using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Flyweight
{
    public interface IVehicle
    {
        public void Drive();
    }

    public class FlyweightCar : IVehicle
    {
        private string _color;
        private string _name;

        public FlyweightCar(string name)
        {
            _name = name;
        }
        public void Drive()
        {
            Console.WriteLine("Drive your " + _color + " " + _name);
        }

        public void SetColor(string color)
        {
            this._color = color;
        }
    }

    public class CarFactory
    {
        private static readonly Dictionary<string, FlyweightCar> cars = new Dictionary<string, FlyweightCar>();

        public FlyweightCar GetCar(string name)
        {
            if (cars.ContainsKey(name))
            {
                return cars[name];
            }

            var car = new FlyweightCar(name);
            cars.Add(name, car);
            return car;
        }

        public int GetCount()
        {
            return cars.Count();
        }
    }
}

/*
    var factory = new CarFactory();
    var car1 = factory.GetCar("Jaguar F-Type");
    car1.SetColor("Grey");
    car1.Drive();

    var car2 = factory.GetCar("Jaguar F-Type");
    car2.SetColor("White");
    car2.Drive();

    var car3 = factory.GetCar("Jaguar XE");
    car3.SetColor("Grey");
    car3.Drive();

    Console.WriteLine("Objects Created: " + factory.GetCount());

    Console.ReadLine();
*/
