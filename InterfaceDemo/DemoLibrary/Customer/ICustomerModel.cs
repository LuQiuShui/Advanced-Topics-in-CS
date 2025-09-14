namespace DemoLibrary.Customer
{
    public interface ICustomerModel
    {
        string City { get; set; }
        string Name { get; set; }
        string EmailAddress {  get; set; }
        bool IsVip {  get; set; }
    }
}