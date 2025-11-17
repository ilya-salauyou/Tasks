using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    public static class BonusCalculator
    {
        //Если НЕ нужно возвращать челов с бонусом 0.0
        public static Dictionary<string, decimal> CalculateBonus(List<Sale> sales)
        {
            sales = sales.Where(x => x.Sum >= 1000m).ToList();
            var managerSales = sales.GroupBy(x => x.Manager);

            Dictionary<string, decimal> managerBonus = new Dictionary<string, decimal>();
            foreach (var ms in managerSales)
            {
                var bonus = ms.Sum(x => x.Sum) * 0.011m;

                if (ms.Max(x => x.Sum) > 250000m)
                    bonus += 10000m;

                managerBonus[ms.Key] = bonus;
            }
            return managerBonus;


        }

        //Если НУЖНО возвращать челов с бонусом 0.0
        public static Dictionary<string, decimal> CalculateBonusIncludeZeros(List<Sale> sales)
        {
            var managerSales = sales.GroupBy(x => x.Manager);

            Dictionary<string, decimal> managerBonus = new Dictionary<string, decimal>();
            foreach (var ms in managerSales)
            {
                var bonus = 0m;
                try
                {
                    bonus = ms.Where(x => x.Sum >= 1000m).Sum(x => x.Sum) * 0.011m;

                    if (ms.Where(x => x.Sum >= 1000m).Max(x => x.Sum) > 250000m)
                        bonus += 10000m;
                }
                catch { }

                managerBonus[ms.Key] = bonus;
            }
            return managerBonus;
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
