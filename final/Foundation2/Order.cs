using System;

class Order
{

    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    public void GetProductInfo()
    {
        Product product = new Product();
        Console.Write("What is the name of the product? ");
        string productIDInput = Console.ReadLine();
        Console.Write("What is the price of the product? ");
        string productQuantity = Console.ReadLine();
        Console.Write("What is the price of the product? ");
        string productPriceInput = Console.ReadLine();
        product._productID = productIDInput;
        product._productPrice = productPriceInput;
        product._productQuantity = productQuantity;
        int productPrice = Convert.ToInt32(productPriceInput) * Convert.ToInt32(productQuantity);
        product.GetProductInfo();
    }
    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}