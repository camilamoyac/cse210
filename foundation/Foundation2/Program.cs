using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Camila Moya", new Address("Altos del Parque 8110", "Santiago", "RM", "Chile")));
        order1.addProductToOrder(new Product(51001, "Aloe Vera hand cream", (float)5.50, 1));
        order1.addProductToOrder(new Product(51002, "Body sugar scrub", (float)8.99, 2));
        order1.addProductToOrder(new Product(51003, "Lavender hand soap", (float)3.99, 1));

        Console.WriteLine("Packing label:");
        foreach (string element in order1.getPackingLabel())
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine("Total cost:");
        Console.WriteLine($"${order1.getTotalCost()}\n");

        Order order2 = new Order(new Customer("Joe Franklin", new Address("45 9th Street", "Marysville", "Florida", "USA")));
        order2.addProductToOrder(new Product(51014, "Blue T-Shirt", (float)15.50, 5));
        order2.addProductToOrder(new Product(51015, "Red shorts", (float)21.99, 1));
        order2.addProductToOrder(new Product(51016, "White baseball cap", (float)12.75, 1));
        
        Console.WriteLine("Packing label:");
        foreach (string element in order2.getPackingLabel())
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine("Total cost:");
        Console.WriteLine($"${order2.getTotalCost()}\n");
    }
}