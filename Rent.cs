using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    internal class Rent
    {
        public int DaysToRent { get; set; }

        public int KilometersPerDay { get; set; }

        private int profits = 0;

        public Rent()
        {
        }

        public Rent(int daysToRent, int kilometersPerDay)
        {
            DaysToRent = daysToRent;
            KilometersPerDay = kilometersPerDay;
        }

        public void calculateRentProfit(int daysToRent, int PricePerDay)
        {
            profits = daysToRent * PricePerDay + profits;
            Console.WriteLine("Total intäkt: " + profits);
        }
    }
}