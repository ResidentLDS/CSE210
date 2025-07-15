class Product
{
    private string _name;
    private string _productid;
    private int _price;
    private int _quantity;
    public Product(string name, string productid, int price, int quantity)
    {
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotal()
    {
        return _price * _quantity;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productid;
    }
}