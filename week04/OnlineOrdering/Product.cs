using System;

public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;


    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public void DisplayTotalCost()
    {
        int totalCost = _price * _quantity;
        Console.WriteLine($"Total cost: ${totalCost}");
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void GetProduct()
    {
        Console.WriteLine($"Product: {_name}, Product ID: {_productId}");
    }
}