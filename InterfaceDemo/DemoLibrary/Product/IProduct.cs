using DemoLibrary.Customer;

namespace DemoLibrary.Product
{
    public interface IProduct
    {
        string Title { get; }
        decimal Price { get; }
        string ID { get; }
        bool HasOrderBeenCompleted { get; }
        void ShipItem(CustomerModel customer);
    }
}
