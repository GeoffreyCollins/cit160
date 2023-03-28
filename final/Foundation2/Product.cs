using System;

class Product
{
    private int _productID;
    private int _productPrice;
    private int _productQuantity;

    public void GetProductInfo()
    {
        int productPrice = _productPrice * _productQuantity;
        Console.WriteLine($"Product ID: {_productID} - Product Price: ${productPrice} - Product Quantity: {_productQuantity}");
    }
}