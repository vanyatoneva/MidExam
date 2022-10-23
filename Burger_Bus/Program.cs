using System;

namespace Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int citiesCount = int.Parse(Console.ReadLine());
            decimal totalProfit = 0.0m;
            for(int i = 1; i <= citiesCount; i++)
            {
                string cityName = Console.ReadLine();
                decimal earnedMoney = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());
                if(i % 3 == 0 && i % 5 != 0)
                {
                    expenses += expenses * 0.5m;
                }
                if(i % 5 == 0)
                {
                    earnedMoney -= earnedMoney * 0.1m;
                }
                decimal profit = earnedMoney - expenses;
                totalProfit += profit;
                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
