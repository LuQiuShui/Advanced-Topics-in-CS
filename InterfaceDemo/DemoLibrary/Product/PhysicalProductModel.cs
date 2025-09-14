using DemoLibrary.Customer;

namespace DemoLibrary.Product
{
    public class PhysicalProductModel : IProduct
    {
        public string Title { get; set; }
        public decimal Price {  get; set; }
        public string ID { get; set; }
        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("\n\n");
                Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
                Console.WriteLine($"Simulating shipping {Title} to {customer.Name} in {customer.City}, it cost {Price} and ID is {ID}.");
            }
        }
    }
}
