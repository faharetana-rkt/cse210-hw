public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // SMT since you're just hard-coding the Products you could just pass in a List<Product> to the constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    private string Line()
    {
        return "**********************************************";
    }

    public void AddToList(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculatePrice();
        }

        if (_customer.IsResident())
        {
            return total + 5;
        }
        else
        {
            return total + 35;
        }
    }

    // SMT Do not use Console in classes. Instead create a method that returns a string, like ToString(), that returns the string 
    // to display by Console in Main(). Take a look at StringBuilder.
    public void GetPackingLabel()
    {
        Console.WriteLine(Line());
        foreach (Product product in _products)
        {
            Console.WriteLine(product.ToStr());
        }
        Console.WriteLine($"Total: {CalculateTotal()} $");
        Console.WriteLine(Line());
    }

    public void GetShippingLabel()
    {
        Console.WriteLine(Line());
        Console.WriteLine(_customer.ToStr());
        Console.WriteLine(Line());
    }
}