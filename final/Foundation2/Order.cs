public class Order
{
    private List<Product> products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.TotalCost();
        }
        totalPrice += _customer.IsInUSA() ? 5 : 35;
        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetType().Name}: {product.GetName()}, Product ID: {product.GetId()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += $"Customer Address: {_customer.GetAddress().DisplayAddress()}\n";
        return label;
    }

}