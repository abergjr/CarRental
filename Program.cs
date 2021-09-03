using System;

namespace CarRental
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cars carOne = new Cars();
            carOne.Model = "Audi";
            carOne.KilometersDriven = 0;
            carOne.PricePerDay = 250;

            Cars carTwo = new Cars();
            carTwo.Model = "Volvo";
            carTwo.KilometersDriven = 1000;
            carTwo.PricePerDay = 100;

            Rent test = new Rent();

            Console.WriteLine("Välkommen till biluthyrningen. Välj i listan vilken bil som passar dig: ");
            string userInput = Console.ReadLine().Trim().ToUpper();

            if (userInput == "AUDI")
            {
                Console.WriteLine("Model: " + carOne.Model + " Pris per dag: " + carOne.PricePerDay + " Kilometer körda: " + carOne.KilometersDriven);
                Console.WriteLine("Vänligen ange hur många dagar du vill hyra bilen samt hur många kilometer du kommer att köra per dag, separera med ett kommatecken.");
                userInput = Console.ReadLine();
                int daysToRent = int.Parse(userInput);
                userInput = Console.ReadLine();
                int kilometersPerDay = int.Parse(userInput);
                test.DaysToRent = daysToRent;
                test.KilometersPerDay = kilometersPerDay;
                test.calculateRentProfit(daysToRent, carOne.PricePerDay);
                carOne.carCalculator(kilometersPerDay, daysToRent);
                Console.WriteLine(carOne.KilometersDriven);
            }
            else if (userInput == "VOLVO")
            {
                Console.WriteLine("Model: " + carTwo.Model + " Pris per dag: " + carTwo.PricePerDay + " Kilometer körda: " + carTwo.KilometersDriven);
                Console.WriteLine("Vänligen ange hur många dagar du vill hyra bilen samt hur många kilometer du kommer att köra per dag, separera med ett kommatecken.");
                userInput = Console.ReadLine();
                int daysToRent = int.Parse(userInput);
                userInput = Console.ReadLine();
                int kilometersPerDay = int.Parse(userInput);
                test.DaysToRent = daysToRent;
                test.KilometersPerDay = kilometersPerDay;
                test.calculateRentProfit(daysToRent, carOne.PricePerDay);
                carOne.carCalculator(kilometersPerDay, daysToRent);
                Console.WriteLine(carTwo.KilometersDriven);
            }
            else
            {
                Console.WriteLine("Något gick fel, testa igen.");
                userInput = Console.ReadLine().Trim().ToUpper();
            }
        }
    }
}