public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void CalculateTotal()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.CalculatePrice();
        }
        if(_customer.isUS()){total += 5;}

        else{
            total += 35;
        }

        Console.WriteLine($"Your total is ${Math.Round(total, 2)}.");
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetShippingInfo());
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetPackingInfo());
        }
    }
}