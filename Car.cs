using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace car2
{
    internal class Car
    {
        public string Brand;
        public string Color;
        public int MaxSpeed;
        public int HorsePower;
        public CarType CarType;

        
        public void ShowInfo()
        {
            Console.WriteLine($"Carinfo: {Brand}, {Color}, {MaxSpeed}");
        }
        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving.");
        }

        public void Honk()
        {
            Console.WriteLine("Honk, Honk!");
        }

        public void Fuel()
        {
            Console.WriteLine($"Car is fueled with {CarType}\n");

            switch (CarType)
            {
                case CarType.Electric:
                    Console.WriteLine();
                    break;
                case CarType.Gas:
                    Console.WriteLine();
                    break;
                case CarType.Diesel:
                    Console.WriteLine();
                    break;
                case CarType.Hybrid:
                    Console.WriteLine();
                    break;
            }
        }

            public void IsFasterThen(Car otherCar)
        {
            if (otherCar.MaxSpeed > MaxSpeed)
            {
                Console.WriteLine($"Car {otherCar.Brand} is faster\n");
            }
            else if (otherCar.MaxSpeed == MaxSpeed)
            {
                Console.WriteLine($"They are equel");
            }
            else
            {
                Console.WriteLine($"Car {Brand} is quiest.");
            }
        }

    }
    
    
}
