using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static List<IProductModel> AddSampleData() 
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" }); ;
            output.Add(new PhysicalProductModel { Title = "T-shirt" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core" });

            return output;
        }

        private static CustomerModel GetCustomer() 
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "shanghai",
                EmailAddress = "Coco@coco.com"
            };
        }
    }
}