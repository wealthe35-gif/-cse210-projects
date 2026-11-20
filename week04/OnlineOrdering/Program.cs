using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "12 Lagos Street", "Lagos", "Lagos", "Nigeria");

        Customer customer1 = new Customer("Emmanuel", address1);

        Product product1 = new Product("Laptop", "P001", 500, 2);
        Product product2 = new Product("Mouse", "P002", 20, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(
            "25 Main Street", "Texas", "Texas", "USA");

        Customer customer2 = new Customer("John", address2);

        Product product3 = new Product("Keyboard", "P003", 40, 1);
        Product product4 = new Product("Monitor", "P004", 200, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("FIRST ORDER");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total: $" + order1.GetTotalCost());

        Console.WriteLine("\nSECOND ORDER");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total: $" + order2.GetTotalCost());
    }
}
    