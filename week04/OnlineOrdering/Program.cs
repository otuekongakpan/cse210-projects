using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Lifewood street", "El Paso", "Texas", "USA");
        Address a2 = new Address("Igando street", "Igando", "Lagos", "Nigeria");
        Customer c1 = new Customer("Matthew", a1);
        Customer c2 = new Customer("Ezra", a2);
        Order o1 = new Order("Shoes,11213,45,1 Shirt,18943,13,4 Trousers,29943,28,2", c1);
        Order o2 = new Order("Shoes,33213,45,2 Shirt,12893,13,3 Trousers,29943,28,2", c1);
        Order o3 = new Order("Shoes,33213,45,1 Shirt,12893,13,4 Trousers,29943,28,2", c2);

        Console.WriteLine("----------PACKING LABEL----------");
        List<Product> products = o1.GetProducts();
        foreach (Product p in products)
        {
            p.GetProduct();
        }
        Console.WriteLine("");

        List<Product> products2 = o2.GetProducts();
        foreach (Product p in products2)
        {
            p.GetProduct();
        }
        Console.WriteLine("");

        List<Product> products3 = o3.GetProducts();
        foreach (Product p in products3)
        {
            p.GetProduct();
        }

        Console.WriteLine("----------SHIPPING LABEL----------");
        o1.DisplayShippingLabel();
        Console.WriteLine("");

        o2.DisplayShippingLabel();
        Console.WriteLine("");

        o3.DisplayShippingLabel();

        Console.WriteLine("----------TOTAL PRICE----------");
        o1.DisplayTotalPrice();
        o2.DisplayTotalPrice();
        o3.DisplayTotalPrice();

    }
}