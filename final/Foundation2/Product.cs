using System;

class Product
{
    public int _productID;
    public int _productPrice;
    public int _productQuantity;

    public void GetProductInfo()
    {
        Console.WriteLine($"Product ID: {_productID} - Product Price: ${_productPrice} - Product Quantity: {_productQuantity}");
    }
}