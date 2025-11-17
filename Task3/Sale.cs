namespace Task3
{
    public class Sale
    {
        public decimal Sum { get; private set; }
        public string Manager { get; private set; }

        public Sale(decimal sum, string manager)
        {
            Sum = sum;
            Manager = manager;
        }
    }
}
