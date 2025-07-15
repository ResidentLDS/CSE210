using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Address fromAddress = new Address("261 Randall Dr, Fair Oaks, California 95630, USA");
        Product product_1 = new Product("Apples", "SKU15827395", 5, 20);
        Product product_2 = new Product("Bananas", "SKU94776453", 2, 17);
        Product product_3 = new Product("Cucumber", "SKU56751329", 3, 26);
        string address_1 = "1250 Main Street, Broomfield, Colorado, USA";
        string name_1 = "Alex Crandall";
        Order shippingLable_1 = new Order(product_1, product_2, product_3, address_1, name_1);

        Product product_4 = new Product("Television", "SKU25418624", 700, 30);
        Product product_5 = new Product("Nintendo Switch", "SKU24962186", 300, 50);
        Product product_6 = new Product("Cabinet", "SKU53981832", 80, 150);
        string address_2 = "22 Ludwigstraße, München, Germany";
        string name_2 = "Lukas Schneider";
        Order shippingLable_2 = new Order(product_4, product_5, product_6, address_2, name_2);

        shippingLable_1.GetShippingLable();
        Console.WriteLine();
        shippingLable_1.GetPackingLable();
        Console.WriteLine();
        shippingLable_2.GetShippingLable();
        Console.WriteLine();
        shippingLable_2.GetPackingLable();


    }
}