using System;

namespace ConsoleApp5
{
    // Base Class
    class Product
    {
        private double price;

        public string Name { get; set; } = "";

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative.");
                }
                else
                {
                    price = value;
                }
            }
        }

        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }

    // Derived Class - Electronics
    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05);
        }
    }

    // Derived Class - Clothing
    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product electronics = new Electronics();
            electronics.Name = "Laptop";
            electronics.Price = 20000;

            Product clothing = new Clothing();
            clothing.Name = "Shirt";
            clothing.Price = 2000;

            Console.WriteLine("Electronics Final Price after 5% discount = " + electronics.CalculateDiscount());
            Console.WriteLine("Clothing Final Price after 15% discount = " + clothing.CalculateDiscount());
        }
    }
}