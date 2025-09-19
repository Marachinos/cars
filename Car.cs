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
            Console.WriteLine($"Bilinfo: {Brand}, {Color}, {MaxSpeed}");
        }
        public void Drive()
        {
            Console.WriteLine($"{Brand} är körbar.");
        }

        public void Honk()
        {
            Console.WriteLine("Honk, Honk!");
        }

        public void Fuel()
        {
            Console.WriteLine($"Bilen tankas med {CarType}\n");

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
                Console.WriteLine($"Bilen {otherCar.Brand} är snabbast.\n");
            }
            else if (otherCar.MaxSpeed == MaxSpeed)
            {
                Console.WriteLine($"Bilarna {otherCar.Brand} och {Brand} är lika snabba.");
            }
            else
            {
                Console.WriteLine($"Car {Brand} is quiest.");
            }
        }

    }
    
    
}
