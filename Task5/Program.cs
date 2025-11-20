using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");

            try
            {
                string data = await AsyncMethod();
                Console.WriteLine("ПЛАГИН: Основная транзакция завершена");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        async static Task<string> AsyncMethod()
        {
            Thread.Sleep(4000);
            return "anyData";
        }
    }
}
