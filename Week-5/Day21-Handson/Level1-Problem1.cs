using System;
using System.Collections.Generic;
using System.Linq;
namespace BankApp
{
    internal class BankAccount
    {
        private string accountNumber = "";
        private double balance;

        public double Balance
        {
            get
            {
                return balance;

            }
        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit Amount cannot be negative");
            }
            balance += amount;
            Console.WriteLine("Amount Deposited: " + amount);
            Console.WriteLine("Updated Balance: " + balance);
        }
        public void WithDraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("WithDrawl amount must be positive");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance.");
                return;
            }
            balance -= amount;
            Console.WriteLine("Amount Withdrwan: " + amount);
            Console.WriteLine("Updated Balance: " + balance);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.AccountNumber = "A10110";

            acc.Deposit(5000);
            acc.WithDraw(3000);
            Console.WriteLine("Current Balance = " + acc.Balance);
            Console.ReadLine();
        }
    }
}