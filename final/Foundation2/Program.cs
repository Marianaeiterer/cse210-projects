using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 North Mill", "Orem", "Utah", "USA");
        Address address2 = new Address("23 Abrahao", "Juiz de Fora", "Minas Gerais", "Brazil");
        
        Customer customer1 = new Customer("Mariana Doe", address1);
        Customer customer2 = new Customer("Sabrina Souza", address2);

        Product product1 = new Product("Shirt", "9878", 20, 3);
        Product product2 = new Product("Jacket", "8293", 70, 1);
        Product product3 = new Product("Blanket", "5555", 150, 2);

        Product product4 = new Product("Eyeliner", "9999", 10, 4);
        Product product5 = new Product("Candle", "7837", 5, 5);
        Product product6 = new Product("Mug", "1234", 15, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach(Order order in orders)
        {
            Console.WriteLine($"\nOrder Packing Label: \n{order.PackingLabel()}");
            Console.WriteLine($"Order Shipping Label: \n{order.ShippingLabel()}");
            Console.WriteLine($"Order Total Cost: ${order.TotalCost()}");
        }






    }
}