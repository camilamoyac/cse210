using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public bool isInUSA()
    {
        return _customerAddress.isInUSA();
    }
    public string getCustomerName()
    {
        return _customerName;
    }
    public string getCustomerAddress()
    {
        return _customerAddress.getFullAddress();
    }
}