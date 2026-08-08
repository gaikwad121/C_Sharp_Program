namespace MyApp;

public class Constructor
{

}
/*

🟢 Practice — Bank Account Constructor

Create a BankAccount class with these instance fields:

string accountHolder;
double balance;
Create a constructor

The constructor should accept:

account holder name
starting balance

Example:

Account Holder: Jyoti
Balance: 50000
Create a method
public void DisplayAccount()

It should print the account details.

In Main()

Create two objects:

Bank 1 → Jyoti → 50000
Bank 2 → Reha → 75000

Expected output:

Account Holder: Jyoti
Balance: 50000

Account Holder: Reha
Balance: 75000*/

public class BankAccountDetails
{
    string accountHolder;
    double balance;

    public BankAccountDetails(string accountHolder, double balance)
    {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    public void DisplayAccount()
    {
        Console.WriteLine($"accountHolder : {accountHolder}");
        Console.WriteLine($"balance : {balance}");
    }

    public class Product
    {
        string productName;
        double price;
        string cityName;
        double distance;
        public Product(string productName,
        double price)
        {
            this.productName = productName;
            this.price = price;
        }
        public Product(string cityName,
            double distance, string ProductName)
        {
            this.cityName = cityName;
            this.distance = distance;
            this.productName = productName;
        }

        public void CalculateTotal(double quantity)
        {
            double total = quantity * price;
            Console.WriteLine($"ProductName : {productName}");
            Console.WriteLine($"Price : {price}");
            Console.WriteLine($"Quantity : {quantity}");

            Console.WriteLine($"Total : {total}");
            Console.WriteLine($"CityName : {cityName}");
            Console.WriteLine($"distance : {distance}");


        }
    }
}