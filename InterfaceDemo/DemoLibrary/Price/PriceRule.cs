using DemoLibrary.Product;
using DemoLibrary.Customer;

namespace DemoLibrary.Price
{
    // 会员9折
    public class MemberTenOffRule : IPriceRule
    {
        public decimal Apply(decimal current, IProduct product, ICustomerModel customer)
        {
            return customer.IsVip ? current * 0.9m : current;
        }
    }

    // 满200减20
    public class Full200Minus20Rule : IPriceRule
    {
        public decimal Apply(decimal current, IProduct product, ICustomerModel customer)
        {
            return current >= 200m ? current - 20m : current;
        }
    }

    // 特定类目95折
    public class CategoryRule : IPriceRule
    {
        public decimal category;

        public decimal Apply(decimal current, IProduct product, ICustomerModel customer)
        {
            return current * category;
        }
    }
}
