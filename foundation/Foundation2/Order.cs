using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void addProductToOrder(Product product)
    {
        _products.Add(product);
    }
    public float getTotalCost()
    {
        float totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.getSubtotalCost();
        }

        if (_customer.isInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }        
        return totalCost;
    }
    public List<String> getPackingLabel()
    {
        List<String> packingLabelList = new List<string>();
        foreach (Product product in _products)
        {
            packingLabelList.Add($"{product.getProductName()} | {product.getProductId()}");
        }
        return packingLabelList;
    }
    public String getShippingLabel()
    {
        return $"{_customer.getCustomerName()}\n{_customer.getCustomerAddress()}";
    }
}