using System;

class Product
{
    public string _productID = "";
    public string _productPrice = "";
    public string _productQuantity = "";

    public void GetProductInfo()
    {
        Console.WriteLine($"Product Name: {_productID} - Price: {_productPrice} - Quantity: {_productQuantity}");
    }

}