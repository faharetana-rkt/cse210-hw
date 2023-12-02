using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("Suite 445 572 Frami Tunnel", "West Cornliusport", "ID 21996", "USA");
        Customer john = new("John Finley", address1);
        List<Product> products1 = new();
        Product banana = new("Banana", 501, 0.5, 5);
        Product ramen = new("Ramen", 111, 1.25, 2);
        Product candy = new("Candy", 109, 0.75, 3);
        products1.Add(banana);
        products1.Add(ramen);
        products1.Add(candy);
        Order johnOrder = new(john, products1);
        Console.WriteLine(johnOrder.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(johnOrder.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine();

        Address address2 = new("Lot 191 Béryl Rose", "Tanamabo V", "Toamasina 501", "MDG");
        Customer itokiana = new("Itokiana Rakotomamonjy", address2);
        List<Product> products2 = new();
        Product laptop = new("Laptop ASUS ROG", 902, 1200, 1);
        Product mouse = new("Gamer Mouse", 901, 125.5, 2);
        Product headphone = new("HeadPhone with mic", 910, 350, 1);
        products2.Add(laptop);
        products2.Add(mouse);
        products2.Add(headphone);
        Order itokianaOrder = new(itokiana, products2);
        Console.WriteLine(itokianaOrder.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(itokianaOrder.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine();

        Address address3 = new("Apt. 908 42823 Romaguera Garden", "Port Lupe", "VT 56337", "USA");
        Customer sally = new("Sally Reynolds", address3);
        List<Product> products3 = new();
        Product airfryer = new("Airfryer", 803, 700, 1);
        Product sofa = new("Linen Sofa", 705, 1500, 1);
        Product chips = new("Pringles", 102, 3.25, 4);
        Product cherry = new("Cherry", 506, 1.35, 10);
        products3.Add(airfryer);
        products3.Add(sofa);
        products3.Add(chips);
        products3.Add(cherry);

        Order sallyOrder = new(sally, products3);
        Console.WriteLine(sallyOrder.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(sallyOrder.GetPackingLabel());
    }

}