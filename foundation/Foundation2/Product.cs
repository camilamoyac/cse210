using System;

public class Product
{
    private int _productId;
    private string _productName;
    private float _productPrice;
    private int _productQuantity;

    public Product(int productId, string productName, float productPrice, int productQuantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public float getSubtotalCost()
    {
        return _productPrice * _productQuantity;
    }
    public string getProductName()
    {
        return _productName;
    }
    public int getProductId()
    {
        return _productId;
    }
}