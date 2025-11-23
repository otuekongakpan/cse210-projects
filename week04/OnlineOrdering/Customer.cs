using System;

public class Customer
{
    private string _customerName;
    private  Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsLivingInUS()
    {
        if (_address.IsLivingInUS() == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    
    public void GetCustomer()
    {
        Console.WriteLine($"Customer: {_customerName}, Address: {_address.GetAddress()}");
    }
}