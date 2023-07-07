using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Talon", "12648 S. Sonora Ave", "Kuna", "Idaho", "USA");
        List<Product> _products1 = new List<Product>(){
            new Product("Phone", 899.99, 1, 1),
            new Product("Laptop", 1250.19, 1, 2),
            new Product("Mouse", 12.95, 5, 3)
        };

        Order order1 = new Order(customer1, _products1);


        Customer customer2 = new Customer("Porter", "123456 S. Road rd", "Boise", "Idaho", "USA");
        List<Product> _products2 = new List<Product>(){
            new Product("Wheat Bread", 2.99, 2, 5),
            new Product("Oranges", 1.00, 8, 6),
            new Product("Potatoes", .99, 12, 7)
        };

        Order order2 = new Order(customer2, _products2);

        order1.PackingLabel();
        order1.ShippingLabel();
        order1.CalculateTotal();

        order2.PackingLabel();
        order2.ShippingLabel();
        order2.CalculateTotal();
        


    }
}