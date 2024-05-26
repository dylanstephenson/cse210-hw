public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetOrderTotal()
    {
        double prodTotal = 0;
        foreach (Product product in _products)
        {
            prodTotal += product.GetTotalCost();
        }
        if (_customer.IsUsaAddress())
        {
            prodTotal += 5;
        }
        else 
        {
            prodTotal += 35;
        }
        return prodTotal;
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Product List:");
        foreach(Product product in _products)
        {
            string prodName = product.GetName();
            string prodId = product.GetId();
            Console.WriteLine($"\tName: {prodName}");
            Console.WriteLine($"\tProduct ID: {prodId}\n");
        }
    }
    public void DisplayShippingLabel()
    {
        string name = _customer.GetName();
        string address = _customer.GetAddress();
        Console.WriteLine("Customer Information:");
        Console.WriteLine($"\tName: {name}");
        Console.WriteLine($"\tAddress: {address}");
    }
}