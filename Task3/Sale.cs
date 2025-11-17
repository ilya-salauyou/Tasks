using System;

namespace Task3
{
    public class Sale
    {
        public decimal Sum { get; private set; }
        public string Manager { get; private set; }

        public Sale(decimal sum, string manager)
        {
            if (sum <= 0) 
                throw new Exception("Сумма продажи не может быть отрицательной");
            if (string.IsNullOrWhiteSpace(manager)) 
                throw new Exception("Имя менеджера должно быит не пустое");

            Sum = sum;
            Manager = manager;
        }
    }
}
