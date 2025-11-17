using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new List<Sale>()
            {
                new Sale(154335m, "Sanya"),
                new Sale(122727m, "Sanya"),
                new Sale(250001m, "Sanya"),
                new Sale(20193m, "Kiril"),
                new Sale(30660m, "Kiril"),
                new Sale(60740m, "Kiril"),
                new Sale(900m, "Tolik")
            };

            Console.WriteLine("Без челов с бонусом 0.0m");
            var bounuses = BonusCalculator.CalculateBonus(sales);
            BonusCalculator.PrintBonuses(bounuses);

            Console.WriteLine("Все челы");
            bounuses = BonusCalculator.CalculateBonusIncludeZeros(sales);
            BonusCalculator.PrintBonuses(bounuses);
        }
    }
}
