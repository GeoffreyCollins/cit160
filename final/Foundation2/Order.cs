using System;

class Order
{
    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}