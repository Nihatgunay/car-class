namespace resize___class
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;
        
        public void Drive(double km)
        {
            if (CurrentFuel <= km * FuelFor1Km)
            {
                Console.WriteLine("You dont have enough fuel");          
                
            }
            else
            {
                CurrentFuel = CurrentFuel - km * FuelFor1Km;
                Millage = Millage + km;
                Console.WriteLine($"brand - {Brand}  model - {Model}  currentFuel - {CurrentFuel}  fuelper1km - {FuelFor1Km}  millage - {Millage}");
            }
        }
        //public void FullData()
        //{
        //    Console.WriteLine($"brand - {Brand}  model - {Model}  currentFuel - {CurrentFuel}  fuelper1km - {FuelFor1Km}  millage - {Millage}");
        //}
        

    }
}
