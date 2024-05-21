namespace resize___class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "07";
            car.CurrentFuel = 30;
            car.FuelFor1Km = 4;
            car.Millage = 500;
            car.Drive(8);
            //car.FullData();

        }
    }
}
