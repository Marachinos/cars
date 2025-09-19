using System.Reflection;

namespace car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();
            ferrari.Color = "Röd";
            ferrari.Brand = "Ferrari";
            ferrari.MaxSpeed = 350;
            ferrari.HorsePower = 500;
            ferrari.CarType = CarType.Gas;

            Car volvo = new Car();
            volvo.Color = "Vit";
            volvo.Brand = "Volvo";
            volvo.MaxSpeed = 250;
            volvo.HorsePower = 300;
            volvo.CarType = CarType.Diesel;

            Car tesla = new Car();
            tesla.Color = "Svart";
            tesla.Brand = "Tesla";
            tesla.MaxSpeed = 250;
            tesla.HorsePower = 400;
            tesla.CarType = CarType.Electric;


            ferrari.ShowInfo();
            ferrari.Drive();
            ferrari.Honk();
            ferrari.Fuel();

            volvo.ShowInfo();
            volvo.Drive();
            volvo.Honk();
            volvo.Fuel();

            tesla.ShowInfo();
            tesla.Drive();
            tesla.Honk();
            tesla.Fuel();

            volvo.IsFasterThen(ferrari);
            tesla.IsFasterThen(volvo);
           
        }
    }
}
