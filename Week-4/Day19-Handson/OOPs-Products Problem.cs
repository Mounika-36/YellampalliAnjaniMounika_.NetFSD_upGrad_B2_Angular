using System;

class Product
{
    // Private variables with underscore
    private int _productId;
    private string _productName;
    private double _unitPrice;
    private int _qty;

    // Constructor with productId parameter
    public Product(int pid)
    {
        _productId = pid;
    }

    // Read-only Property
    public int ProductId
    {
        get { return _productId; }
    }

    // Property for ProductName
    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    // Property for UnitPrice
    public double UnitPrice
    {
        get { return _unitPrice; }
        set { _unitPrice = value; }
    }

    // Property for Quantity
    public int Quantity
    {
        get { return _qty; }
        set { _qty = value; }
    }

    // Method to display details
    public void ShowDetails()
    {
        double totalAmount = _unitPrice * _qty;

        Console.WriteLine("Product Id   : " + _productId);
        Console.WriteLine("Product Name : " + _productName);
        Console.WriteLine("Unit Price   : " + _unitPrice);
        Console.WriteLine("Quantity     : " + _qty);
        Console.WriteLine("Total Amount : " + totalAmount);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Product Id: ");
        int id = int.Parse(Console.ReadLine());

        Product p = new Product(id);

        Console.Write("Enter Product Name: ");
        p.ProductName = Console.ReadLine();

        Console.Write("Enter Unit Price: ");
        p.UnitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        p.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nProduct Details");
        p.ShowDetails();
    }
}