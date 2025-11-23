using System;
using System.Collections.Generic;
using System.Security.Cryptography;


public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;

    public Order(string prod, Customer customer)
    {
        _customer = customer;
        string[] products = prod.Split(' ');

        foreach (string p in products)
        {
            string[] parts = p.Trim().Split(',');

            string name = parts[0];
            int id = int.Parse(parts[1]);
            int price = int.Parse(parts[2]);
            int quantity = int.Parse(parts[3]);

            Product p1 = new Product(name, id, price, quantity);
            _product.Add(p1);
        }
    }

    

    int shippingCost = 0;
    public void DisplayShippingCost()
    {

        if (_customer.IsLivingInUS()== true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        Console.WriteLine($"Shipping cost: {shippingCost}");

    }

    public void DisplayTotalPrice()
    {
        int totalCost = 0;

        foreach (Product p in _product)
        {
            totalCost += p.GetPrice() * p.GetQuantity();
        }

        int shippingCost = _customer.IsLivingInUS() ? 5 : 35;

        int totalPrice = totalCost + shippingCost;

        Console.WriteLine($"Total price: ${totalPrice}");
    }


    public void DisplayPackingLabel()
    {
        foreach (Product p in _product)
        {
            p.GetProduct();
        }
    }

    public void DisplayShippingLabel()
    {
        _customer.GetCustomer();
    }
    
    public List<Product> GetProducts()
    {
        return _product;
    }
}