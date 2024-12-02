using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

         // Create customers
        Customer customer1 = new Customer("Erjok Agot", new Address("123 spine St", "Nalyaa Estates", "Kla", "UGA"));
        Customer customer2 = new Customer("Chut Achol", new Address("456 Wabiduku Ave", "Kiwatule", "Wak", "UGA"));

        // Create products
        Product product1 = new Product("Widget", "W123", 10.50m, 3);
        Product product2 = new Product("Gadget", "G456", 15.75m, 2);
        Product product3 = new Product("Thingamajig", "T789", 8.25m, 5);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotalCost()}");
    }
}