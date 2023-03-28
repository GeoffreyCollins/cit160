using System;

class Product
{
    public int _productID = 0;
    public int _productPrice = 0;
    public int _productQuantity = 0;

    public void GetProductInfo()
    {
        Console.WriteLine($"Product Name: {_productID} - Price: {_productPrice} - Quantity: {_productQuantity}");
    }

}