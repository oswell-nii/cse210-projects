using System;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Product 1", "P001", 10.99, 2);
        Product product2 = new Product("Product 2", "P002", 5.99, 3);

        // Create customers
        Address customerAddress1 = new Address("123 Main St", "Newyork", "NY", "USA");
        Customer customer1 = new Customer("John Doe", customerAddress1);

        Address customerAddress2 = new Address("456 Oak St", "Ontario", "OT", "Canada");
        Customer customer2 = new Customer("Jane Smith", customerAddress2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice():F2}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice():F2}");
    }
}