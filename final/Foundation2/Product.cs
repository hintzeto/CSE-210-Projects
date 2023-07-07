public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, double price, int quantity, int id)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_name}, {_id}";
    }
}