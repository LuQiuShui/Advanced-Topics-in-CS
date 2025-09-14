namespace DemoLibrary.Customer
{
    public class CustomerModel : ICustomerModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public bool IsVip {  get; set; }
    }
}
