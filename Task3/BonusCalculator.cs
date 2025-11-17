using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    public static class BonusCalculator
    {
        private const decimal MinSaleThreshold = 1000m;
        private const decimal LargeSaleThreshold = 250000m;
        private const decimal BasicRate = 0.011m;
        private const decimal SaleBonus = 10000m;

        public static Dictionary<string, decimal> CalculateBonus(List<Sale> sales)
        {
           return sales
            .Where(s => s.Sum >= MinSaleThreshold)
            .GroupBy(s => s.Manager)
            .ToDictionary(
                group => group.Key,
                group =>
                {
                    decimal totalSales = 0m;
                    decimal maxSale = 0m;

                    foreach (var sale in group)
                    {
                        totalSales += sale.Sum;
                        if (sale.Sum > maxSale)
                        {
                            maxSale = sale.Sum;
                        }
                    }

                    var bonus = totalSales * BasicRate;

                    if (maxSale > LargeSaleThreshold)
                        bonus += SaleBonus;

                    return bonus;
                }
            );
        }

        public static void PrintBonuses(Dictionary<string, decimal> managerBonuses)
        {
            foreach (var mb in managerBonuses)
            {
                Console.WriteLine($"Manager: {mb.Key}, bonus: {mb.Value},");
            }
        }
    }
}
