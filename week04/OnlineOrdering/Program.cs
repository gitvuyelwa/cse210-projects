using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>
    {
        new Product("Widget", "W123", 19.99, 2),
        new Product("Gadget", "G456", 29.99, 1)
    };
        Order order1 = new Order(customer1, products1);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Price: {order1.CalculateTotalPrice():C}");
        Console.WriteLine(new string('-', 40));

        Address address2 = new Address("456 Elm St", "Metropolis", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        List<Product> products2 = new List<Product>
    {
        new Product("Thingamajig", "T789", 15.99, 3),
        new Product("Doodad", "D012", 45.00, 1)
    };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Price: {order2.CalculateTotalPrice():C}");
    }
}
