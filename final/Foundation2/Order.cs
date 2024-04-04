public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int TotalCost()
    {
        int total = 0;
        foreach(Product product in _products)
        {
            total += product.TotalCost();
        }

        if(_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
    public string PackingLabel()
    {
        string order_receipt = "Follow the items in the order: ";

        foreach(Product product in _products)
        {
            order_receipt += $"\n{product.ProductDetails()}";
        }   

        return order_receipt;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()} \n{_customer.GetAddress().DisplayAddress()}";
    }
}