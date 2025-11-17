using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mess;

            ////Разрешённый
            var workOrder1 = new WorkOrder(Status.Active, 1);
            workOrder1.TryChangeStatus(Status.Completed, out mess);
            Console.WriteLine(mess);

            ////Разрешённый
            var workOrder2 = new WorkOrder(Status.Active, 3);
            workOrder2.TryChangeStatus(Status.Paused, out mess);
            Console.WriteLine(mess);

            ////Запрещённый
            var workOrder3 = new WorkOrder(Status.Active, 2);
            workOrder3.TryChangeStatus(Status.Paused, out mess);
            Console.WriteLine(mess);

            ////Запрещённый
            var workOrder4 = new WorkOrder(Status.Paused, 1);
            workOrder4.TryChangeStatus(Status.Completed, out mess);
            Console.WriteLine(mess);

            ////Запрещённый
            var workOrder5 = new WorkOrder(Status.Active, 4);
            workOrder5.TryChangeStatus(Status.Completed, out mess);
            Console.WriteLine(mess);
        }
    }
}
