using DemoLibrary.Customer;
using DemoLibrary.Product;
using DemoLibrary.Price;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "orders.json";
            string json = File.ReadAllText(filePath);

            using JsonDocument doc = JsonDocument.Parse(json);

            List<CustomerModel> customers = new List<CustomerModel>();
            List<PhysicalProductModel> physicalOrders = new List<PhysicalProductModel>();
            List<DigitalProductModel> digitalOrders = new List<DigitalProductModel>();
            foreach (var element in doc.RootElement.EnumerateArray())
            {
                CustomerModel customer = new CustomerModel
                {
                    Name = element.GetProperty("Name").GetString(),
                    City = element.GetProperty("City").GetString(),
                    EmailAddress = element.GetProperty("EmailAddress").GetString(),
                    IsVip = element.GetProperty("IsVip").GetBoolean()
                };

                customers.Add(customer);
                var orderEl = element.GetProperty("Order");

                if (element.GetProperty("Order").GetProperty("ProductType").GetString() == "PP")
                {
                    PhysicalProductModel ppm = new PhysicalProductModel
                    {
                        Title = orderEl.GetProperty("Title").GetString(),
                        Price = orderEl.GetProperty("BasePrice").GetDecimal(),
                        ID = orderEl.GetProperty("ID").GetString(),
                        HasOrderBeenCompleted = orderEl.GetProperty("HasOrderBeenCompleted").GetBoolean()
                    };

                    physicalOrders.Add(ppm);
                    ppm.ShipItem(customer);

                    if (ppm.HasOrderBeenCompleted == false)
                    {
                        List<IPriceRule> rules = new List<IPriceRule>
                        {
                            new MemberTenOffRule(),
                            new Category95Rule
                            {
                                category = orderEl.GetProperty("DiscountApplied").GetDecimal()
                            },
                            new Full200Minus20Rule(),
                        };

                        decimal finalPrice = ppm.Price;

                        foreach (var rule in rules)
                        {
                            finalPrice = rule.Apply(finalPrice, ppm, customer);
                        }

                        Console.WriteLine($"ppm这次交易的总金额是{finalPrice}");
                        Console.WriteLine("\n\n");
                    }
                }
                else
                {
                    DigitalProductModel dpm = new DigitalProductModel
                    {
                        Title = orderEl.GetProperty("Title").GetString(),
                        Price = orderEl.GetProperty("BasePrice").GetDecimal(),
                        ID = orderEl.GetProperty("ID").GetString(),
                        HasOrderBeenCompleted = orderEl.GetProperty("HasOrderBeenCompleted").GetBoolean()
                    };

                    digitalOrders.Add(dpm);
                    dpm.ShipItem(customer);

                    if(dpm.HasOrderBeenCompleted == false)
                    {
                        List<IPriceRule> rules = new List<IPriceRule>
                        {
                            new MemberTenOffRule(),
                            new Category95Rule
                            {
                                category = orderEl.GetProperty("DiscountApplied").GetDecimal()
                            },
                            new Full200Minus20Rule(),
                        };

                        decimal finalPrice = dpm.Price;

                        foreach (var rule in rules)
                        {
                            finalPrice = rule.Apply(finalPrice, dpm, customer);
                        }

                        Console.WriteLine($"dpm这次交易的总金额是{finalPrice}");
                        Console.WriteLine("\n\n");
                    }
                }
            }
        }
    }
}