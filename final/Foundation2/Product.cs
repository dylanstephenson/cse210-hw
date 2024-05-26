public class Product
{
    // Attributes
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // constructor - added the quantity = 1 default parameter so that there can be a single constructor, but the quantity can be changed.
    public Product( string name, string productId, double price, int quantity = 1)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // methods
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _productId;
    }
    

}