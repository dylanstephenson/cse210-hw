using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Guitar", "GUI455", 849.99);
        Product product2 = new Product("Dumbbells", "DUW038", 39.59, 2);
        Product product3 = new Product("Nintendo Switch", "MAR100", 249.99, 4);
        Product product4 = new Product("Bookcase", "RDL995", 59.99, 2);

        Address address1 = new Address("321 Grapes Dr","Kennewick","WA", "USA");
        Address address2 = new Address("9 Ruedela Paix", "Lille", "Hauts-De-France", "France");

        Customer customer1 = new Customer("Johnny Jones", address1);
        Customer customer2 = new Customer("Jean-Claude Michel", address2);

        List<Product> products1 = new List<Product>() {product1, product2};
        List<Product> products2 = new List<Product>() {product3, product4};

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order #1:");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"\nOrder Total: ${Math.Round(order1.GetOrderTotal(), 2)}\n");

        Console.WriteLine("Order #2:");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"\nOrder Total: ${Math.Round(order2.GetOrderTotal(), 2)}");
        
    }
}