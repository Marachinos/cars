using System.Reflection;

namespace car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();
            ferrari.Color = "Red";
            ferrari.Brand = "Ferrari";
            ferrari.MaxSpeed = 350;
            ferrari.HorsePower = 500;
            ferrari.CarType = CarType.Gas;

            Car volvo = new Car();
            volvo.Color = "White";
            volvo.Brand = "Volvo";
            volvo.MaxSpeed = 200;
            volvo.HorsePower = 300;
            volvo.CarType = CarType.Diesel;

            ferrari.ShowInfo();
            ferrari.Drive();
            ferrari.Honk();
            ferrari.Fuel();

            volvo.ShowInfo();
            volvo.Drive();
            volvo.Honk();
            volvo.Fuel();

            volvo.IsFasterThen(ferrari);
        }
    }
}
