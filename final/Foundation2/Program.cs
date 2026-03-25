using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address a1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("Rachel Coleman", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Book", "B001", 10, 2));
        order1.AddProduct(new Product("Pen", "P002", 2, 5));


        // Customer 2 (International)
        Address a2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Alex Smith", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Notebook", "N003", 5, 3));
        order2.AddProduct(new Product("Pencil", "P004", 1, 10));


        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();


        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine();
    }
}