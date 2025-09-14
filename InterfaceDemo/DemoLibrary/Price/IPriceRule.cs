using DemoLibrary.Product;
using DemoLibrary.Customer;

namespace DemoLibrary.Price
{
    public interface IPriceRule
    {
        decimal Apply(decimal current, IProduct product, ICustomerModel customer);
    }
}
