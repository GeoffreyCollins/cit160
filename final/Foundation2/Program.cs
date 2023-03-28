using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        Product product = new Product();
        Order order = new Order();

        int choice = -1;

        while (choice != 0)
        {
            Console.Write("Enter 1 to continue adding products, Enter 0 to end the program and get the price");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    customer.GetCustomerInfo();
                    product.GetProductInfo();
                    break;
                case 0:

                    break;
            }
        }
    }
}