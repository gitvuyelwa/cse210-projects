using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerInfo()
    {
        return $"Customer Name: {_name}, Address: {_address.GetAddressInfo()}";
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}