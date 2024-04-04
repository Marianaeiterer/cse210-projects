using System.Data.Common;
using System.Runtime.CompilerServices;

public class Product
{
    private string _name;
    private string _id;
    private int _price;
    
    private int _quantity;

    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _price * _quantity;
    }

    public string ProductDetails()
    {
        return $"{_id}:{_name} - Price: {_price} Quantity: {_quantity}";
    }

}