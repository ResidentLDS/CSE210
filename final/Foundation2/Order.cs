using System.ComponentModel;

class Order
{
    private List<Product> _productList;
    private Customer _customer;
    public Order(Product product_1, Product product_2, Product product_3, string address, string name)
    {
        _productList = new List<Product> { product_1, product_2, product_3 };
        _customer = new Customer(name, address);
    }
    public int GetTotalPrice()
    {
        int price = 0;
        foreach (Product p in _productList)
        {
            price += p.GetTotal();
        }
        price += _customer.GetShippingPrice();
        return price;
    }

    public void GetShippingLable()
    {
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }

    public void GetPackingLable()
    {
        Console.WriteLine($"Shipping price ${_customer.GetShippingPrice()}");
        foreach (Product p in _productList)
        {
            Console.WriteLine($"{p.GetName()} {p.GetProductID()}\n${p.GetPrice()} {p.GetQuantity()} items = ${p.GetTotal()}");
        }
        Console.WriteLine($"Total price ${GetTotalPrice()}");
    }
}