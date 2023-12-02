public class Product
{
	private string _name;
	private int _productId;
	private double _price;
	private int _quantity;

	public Product(string name, int ID, double price, int quantity)
	{
		_name = name;
		_productId = ID;
		_price = price;
		_quantity = quantity;
	}

	public double CalculatePrice()
	{
		return _price * _quantity;
	}

	public override string ToString()
	{
		return $"{_productId}: {_name}";
	}
}
