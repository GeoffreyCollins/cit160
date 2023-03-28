using System;

class Order
{

    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    public void GetProductInfo()
    {
        Product product = new Product();
        Console.Write("What is the name of the product? ");
        int productIDInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the price of the product? ");
        int productQuantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the price of the product? ");
        int productPriceInput = Convert.ToInt32(Console.ReadLine());
        product._productID = productIDInput;
        product._productPrice = productPriceInput;
        product._productQuantity = productQuantity;
        float productPrice = productPriceInput * productQuantity;
        Console.WriteLine($"Product: {productIDInput} - Price: {productPrice} - Quantity: {productQuantity}");
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