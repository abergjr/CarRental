using System;

namespace CarRental
{
    internal class Cars
    {
        public string Model { get; set; }
        public int PricePerDay { get; set; }

        public int KilometersDriven { get; set; }

        public Cars()
        {
        }

        public Cars(string model, int pricePerDay, int kilometersDriven)
        {
            Model = model;
            PricePerDay = pricePerDay;
            KilometersDriven = kilometersDriven;
        }

        public void carCalculator(int kilometersPerDay, int daysToRent)
        {
            KilometersDriven = kilometersPerDay * daysToRent + KilometersDriven;
        }
    }
}