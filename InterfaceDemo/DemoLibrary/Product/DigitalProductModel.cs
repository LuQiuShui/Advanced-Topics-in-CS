using DemoLibrary.Customer;

namespace DemoLibrary.Product
{
    public class DigitalProductModel : IProduct
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ID { get; set; }
        public bool HasOrderBeenCompleted { get; set; }
        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("\n\n");
                Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}, it cost {Price} and ID is {ID}.");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
