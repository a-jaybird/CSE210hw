using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
    //     Console.WriteLine("Hello Foundation2 World!");
        Product prod1 = new Product();
        prod1.SetProduct("bread");
        prod1.SetProductId("br34d");
        prod1.SetPricePerUnit(1);
        prod1.SetQuantity(5);
        Product prod2 = new Product();
        prod2.SetProduct("butter");
        prod2.SetProductId("2");
        prod2.SetPricePerUnit((float).50); //double parantheses show type cast
        prod2.SetQuantity(10);
        Product prod3 = new Product();
        prod3.SetProduct("jam");
        prod3.SetProductId("34");
        prod3.SetPricePerUnit((float)2.50);
        prod3.SetQuantity(5);
        Product prod4 = new Product();
        prod4.SetProduct("ham");
        prod4.SetProductId("w19");
        prod4.SetPricePerUnit(5);
        prod4.SetQuantity(4);
     products.Add(prod1);
     products.Add(prod4);
     Order order1 = new Order();
        order1.SetProductList(products);
     Customer customer1 = new Customer("Joe Green", new Address("123 s street","mountsville", "Virginia", "USA"));
     order1.SetCustomer(customer1);
     order1.shippingPrice();
     Console.WriteLine("Packing label:");
     Console.WriteLine(order1.PackingLabel());
     Console.WriteLine("Shipping Label:");
     Console.WriteLine(order1.ShippingLabel()); 
    Console.WriteLine($"Order total: ${order1.FindOrderTotal()}");
     

     products =new List<Product>();
        products.Add(prod2);
        products.Add(prod3);
        products.Add(prod1);


     Order order2 = new Order();
        order2.SetProductList(products);
     Customer customer2 = new Customer("Sophie Hatter", new Address("12 Green St","Kingbury", "Surrey", "England"));
     order2.SetCustomer(customer2);
     order2.shippingPrice();
     Console.WriteLine("Packing label:");
     Console.WriteLine(order2.PackingLabel());
     Console.WriteLine("Shipping Label:");
     Console.WriteLine(order2.ShippingLabel()); 
    Console.WriteLine($"Order total: ${order2.FindOrderTotal()}");     
    }
}