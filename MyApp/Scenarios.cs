using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MyApp;

public class Scenarios
{
    //You are creating a login system. You want to check whether a user entered the correct username and password.
    public static string pass = "Admin@123";
    public static string UName = "Admin";
    public void UserLogin()
    {
        Console.WriteLine("Enter your username");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password");

        string password = Console.ReadLine();
        if (username.Equals(UName) && password.Equals(pass))
        {
            Console.WriteLine("Welcome ...Login Successful !");
        }
        else
        {
            Console.WriteLine("Invalid Credentials");
        }
    }

    /*A customer buys 3 products, each costing ₹100.

    Write C# code to calculate the total price.

    Then add this rule:

    If total is greater than ₹250 → give 10% discount
    Otherwise → no discount

    What will be the final amount?*/
    public void ProductDiscount()
    {
        Console.WriteLine("Enter how many product customer buy");
        int total = 0;
        double amount = 0;
        double discount = 0;
        double finaleAmount = 0;
        int product = int.Parse(Console.ReadLine());

        int price = 100;

        amount = product * price;

        if (amount > 250)
        {
            discount = amount * 10 / 100;
            finaleAmount = amount - discount;
            Console.WriteLine(finaleAmount);
        }
        else
        {
            Console.WriteLine("No discount");
        }

    }
    /*A college wants to check whether a student has passed.

Ask the user to enter marks.*/
    public void studentResult()
    {
        string UserChoice = "";
        do
        {
            Console.WriteLine("Enter the marks");
            int marks = int.Parse(Console.ReadLine());
            if (marks >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.WriteLine("Enter user choice");
            UserChoice = Console.ReadLine().ToLower();

        }
        while (UserChoice == "Yes");
        Console.WriteLine("The marks check is done ! .. ");

    }

    /*Practice 2 — Shopping Discount

A shop gives discounts based on the purchase amount.

Rules:

Amount	Discount
Below ₹500	No discount
₹500–₹999	5%
₹1000 or more	10%
Example
Enter purchase amount:
1200

Total Amount: 1200
Discount: 120
Final Amount: 1080
*/
    public void shoppingDiscount()
    {
        string userChoice = "";
        double discount = 0;
        double discount2 = 0;
        double finaleAmonut = 0;
        double finaleAmonut2 = 0;


        do
        {
            Console.WriteLine("Enter total amount of shopping");
            double Amount = double.Parse(Console.ReadLine());
            //  discount2=Amount*10/100;
            // finaleAmonut2=Amount-discount;

            if (Amount < 500)
            {
                Console.WriteLine("No discount");
            }
            else if (Amount >= 500 && Amount < 1000)
            {
                discount = Amount * 5 / 100;
                finaleAmonut = Amount - discount;

                Console.WriteLine($"5% discount {discount} = {finaleAmonut}");
                Console.WriteLine($"Discount {finaleAmonut - discount}");

            }
            else if (Amount >= 1000)
            {
                discount = Amount * 10 / 100;
                finaleAmonut = Amount - discount;
                Console.WriteLine($"10% discount{discount} = {finaleAmonut}");
                Console.WriteLine($"Discount {finaleAmonut - discount}");
            }
            else
            {
                Console.WriteLine("please Enter valid amount");
            }
            Console.WriteLine("Enter your choice");
            userChoice = Console.ReadLine().ToLower();
        }
        while (userChoice == "yes");
        Console.WriteLine("Thanks for shopping !");

    }
    /*
    Enter first number: 20
    Enter second number: 5
    Enter operator: *

    Then display:

    Result: 100

    Support:

    +  Addition
    -  Subtraction
    *  Multiplication
    /  Division*/
    public void Calculator()
    {
        string userChoice = "";
        do
        {
            Console.WriteLine("Enter a first Number");
            int sum = 0;
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second Number");

            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your choice  for what operation you want perform !");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Add":
                    Console.WriteLine($" Addition {a + b}");
                    break;
                case "Sub":
                    Console.WriteLine($" Substraction {a - b}");
                    break;
                case "Mul":
                    Console.WriteLine($" Multiplication {a * b}");
                    break;
                case "Div":
                    Console.WriteLine($" Divison {a / b}");
                    break;
                case "Rem":
                    Console.WriteLine($" Reminder {a % b}");
                    break;
            }

            Console.WriteLine("Enter userchoice");
            userChoice = Console.ReadLine().ToLower();
        } while (userChoice == "yes");
        Console.WriteLine("Thanks ! program ended");

    }
    /*
    Print Numbers

    Ask:

    Enter a number: 5

    Output:

    1
    2
    3
    4
    5*/
    public void printNumber()
    {
        Console.WriteLine("Enter a number");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
    /*

    Practice 5 — Product Counter

A customer buys products.

Ask:

Enter number of products: 5

Output:

Product 1
Product 2
Product 3
Product 4
Product 5*/

    public void ProductCounter()
    {
        Console.WriteLine("Enter how many product you want !");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("Product");
        }
    }
    /*Scenario 6 — ATM Withdrawal

You are creating an ATM program.

Ask the user:

Enter your account balance: 5000
Enter withdrawal amount: 2000

Rules:

If withdrawal amount is greater than balance → "Insufficient balance"
Otherwise subtract the amount from balance.
If the withdrawal amount is 0 or negative, show "Invalid amount".

Expected output:

Enter your account balance: 5000
Enter withdrawal amount: 2000

Withdrawal successful
Remaining balance: 3000
Your requirements

Try to use:
if / else
&& or ||
return
double or int*/
    public void AtmWithdraw()
    {
        string userChoice = "";
        do
        {
            double RemBalance = 0;
            Console.WriteLine("Enter your account balance : ");
            double AccountBalance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter withdrawal amount: ");
            double WithDrawlAmount = double.Parse(Console.ReadLine());
            if (WithDrawlAmount > AccountBalance || WithDrawlAmount <= 0)
            {
                Console.WriteLine
                ("Invalid amount");
            }
            else if (AccountBalance > WithDrawlAmount)
            {
                RemBalance = AccountBalance - WithDrawlAmount;

                Console.WriteLine($"Withdrawal successful : Remaining balance : {RemBalance}");
            }
            Console.WriteLine("Enter userchoice");
            userChoice = Console.ReadLine().ToLower();
        } while (userChoice == "yes");
        Console.WriteLine("Thanks ! program ended");

    }

    /*
    Scenario 1 — Bank Balance (return)

Create a method:

public double CheckBalance(double balance)

Rules:

If balance is less than 0, return 0.
Otherwise return the balance.

Example:

Enter balance: 5000
Balance: 5000*/
    public double CheckBalance(double balance)
    {

        if (balance < 0)
        {
            return 0;
        }
        else
        {
            return balance;
        }

    }

    /*
    Scenario 2 — Number Checker (continue)

    Ask the user to enter 5 numbers.

    Print only the numbers that are positive.

    Example:

    Enter number: 10
    Enter number: -5
    Enter number: 20
    Enter number: -2
    Enter number: 30

    Positive numbers:
    10
    20
    30

    Hint: Use for + continue*/

    public void NumberCheck()
    {
        Console.WriteLine("Enter array size");

        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Positive numbers:"); // Check positive numbers
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] < 0)
            {
                continue;
            }


            Console.WriteLine(arr[i]);
        }
    }

    /*
    Scenario 3 — Login Attempts (break)

    Create a login system.

    Correct credentials:

    Username: Admin
    Password: Admin@123

    Give the user 3 attempts.

    If login is successful:

    Login successful!

    Stop trying immediately.

    If all 3 attempts fail:

    Account locked!*/
    public void LoginAttempt()
    {
        int count = 0;
        string Username = "Admin";
        string Password = "Admin@123";
        for (int i = 1; i <= 3; i++)
        {
            if (Username == "Admin" && Password == "Admin@123")
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else if (Username != "Admin" || Password != "Admin@123")
            {
                Console.WriteLine("Username or password in invalid logging failed");
                count++;
            }
            if (count > 3)
            {
                Console.WriteLine("Account locked!");
            }

        }

    }

    /*Scenario 4 — Student Names (foreach)

    Create an array:

    string[] students = { "Rahul", "Amit", "Priya", "John", "Sara" };

    Use foreach to print:

    Student: Rahul
    Student: Amit
    Student: Priya
    Student: John
    Student: Sara

    Then ask the user for a name and check whether that student exists.*/

    public void StudentExistOrNot()
    {
        string[] names = { "Rahul", "Amit", "Priya", "John", "Sara" };

        Console.WriteLine("Enter name which you want to verify exist or not !");
        string name = Console.ReadLine();
        foreach (string ExistName in names)
        {
            if (ExistName.Equals(name))
            {
                Console.WriteLine($"The student name is exist {ExistName}=={name}");
                break;
            }
            else
            {
                Console.WriteLine($"The student name is not exist {ExistName} != {name}");

            }

        }
    }
    /*

    Scenario 5 — ATM Menu (while)

Create an ATM menu:

1. Check Balance
2. Deposit
3. Withdraw
4. Exit

Keep showing the menu until the user chooses 4.

Example:

Enter choice: 1
Balance: ₹5000

Enter choice: 2
Enter deposit: ₹1000
Balance: ₹6000

Enter choice: 3
Enter withdrawal: ₹2000
Balance: ₹4000

Enter choice: 4
Thank you!*/


    public void AtmMenu()
    {
        string userWantContinue = "";
        do
        {
            Console.WriteLine("What operation user want to perform");
            int choice = int.Parse(Console.ReadLine());
            int AccountBalance = 5000;
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your account balance is {AccountBalance}");
                    break;

                case 2:
                    Console.WriteLine(" Enter  deposit Amount");

                    int deposit = int.Parse(Console.ReadLine());
                    double AfterDeposite = AccountBalance + deposit;
                    Console.WriteLine($"Account Balance {AfterDeposite}");
                    break;
                case 3:
                    Console.WriteLine("Enter  withdrawal: Amount");

                    int withdrawal = int.Parse(Console.ReadLine());

                    if (withdrawal > AccountBalance)
                    {
                        Console.WriteLine($"Your account balance is insufficient {AccountBalance - withdrawal}");
                        break;
                    }
                    Console.WriteLine($"Account Balance {AccountBalance - withdrawal}");
                    break;
                default:
                    Console.WriteLine("PLease select valid option");
                    break;
            }
            Console.WriteLine("Do you want to continue !");
            userWantContinue = Console.ReadLine();
        } while (userWantContinue == "yes");
        Console.WriteLine("program ended");
    }
    /*
    Electricity Bill

Create ElectricityBill().

Ask for units consumed.

0–100 → ₹5/unit
101–200 → ₹7/unit
Above 200 → ₹10/unit

Print the total bill.*/
    public void ElectricityBill()
    {
        string UserChoice = "";
        do
        {
            int totalBill = 0;
            Console.WriteLine("Enter Units consumed : ");
            int unit = int.Parse(Console.ReadLine());
            if (unit <= 100)
            {
                totalBill = unit * 5;
                Console.WriteLine(totalBill);
            }
            else if (unit > 100 && unit <= 200)
            {
                totalBill = unit * 7;
                Console.WriteLine(totalBill);
            }
            else if (unit > 200)
            {
                totalBill = unit * 10;
                Console.WriteLine(totalBill);
            }
            Console.WriteLine("Enter user choice !");
            UserChoice = Console.ReadLine();

        } while (UserChoice == "yes");
        Console.WriteLine("Program Ended");
    }

    /*2. Even or Odd

    Ask the user for a number.

    Output:

    Even

    or

    Odd*/

    public void EvenOdd()
    {
        Console.WriteLine("Enter any number !");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
    /*
    3. Positive, Negative, or Zero

    Ask for a number.

    Output one of:

    Positive
    Negative
    Zero
    */
    public void positiveNegativeZero()
    {
        Console.WriteLine("Enter any number !");
        int num = int.Parse(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (num > 0)
        {
            Console.WriteLine("Positive");

        }
        else
        {
            Console.WriteLine("Negative");
        }
    }
    /*
    Largest of Two Numbers

    Ask for two numbers and print the larger number.

    Example:

    Enter A: 20
    Enter B: 15

    Largest: 20*/

    public void LargestTwo()
    {
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        int result = a > b ? a : b;
        Console.WriteLine(result);
    }

    /*
    Age Category

Ask the user's age.

Rules:

0–12 → Child
13–19 → Teenager
20–59 → Adult
60+ → Senior Citizen
*/
    public void AgeCategory()
    {
        string EnterUserChoice = "";
        do
        {
            Console.WriteLine("Enter first number");
            int Age = int.Parse(Console.ReadLine());
            if (Age >= 0 && Age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (Age >= 13 && Age <= 19)
            {
                Console.WriteLine("Teenager");

            }
            else if (Age >= 20 && Age <= 59)
            {
                Console.WriteLine("Adult");

            }
            else
            {
                Console.WriteLine("Senior Citizen");

            }
            Console.WriteLine("Enter your choice");
            EnterUserChoice = Console.ReadLine();
        } while (EnterUserChoice == "yes");
        Console.WriteLine("Programe Ended");
    }
    /*
    Print Even Numbers

    Ask:

    Enter number: 10

    Print:

    2
    4
    6
    8
    10*/

    public void printEvent()
    {
        Console.WriteLine("Enter any number");

        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    /*

    Sum of Numbers

Ask:

Enter number: 5

Calculate:

1 + 2 + 3 + 4 + 5 = 15*/
    public void sumOfNumber()
    {
        int sum = 0;
        Console.WriteLine("Enter any number");

        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
    /*
    9. Count Positive Numbers

    Ask the user to enter 5 numbers.

    Count how many are positive.*/


    public void CountPositiveNum()
    {
        Console.WriteLine("Enter any number");
        int count = 0;
        int[] arr = new int[8];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Positive number count  :  {count}");


    }
    /*
    10. Skip Negative Numbers

Ask the user to enter 10 numbers.

Negative → skip using continue
Positive → print
Zero → print "Zero"*/
    public void SkipNegativeNum()
    {
        Console.WriteLine("Enter any number");
        int count = 0;
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                continue;
            }
            else if (arr[i] > 0)
            {
                Console.WriteLine(arr[i]);
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
    /*
    11. Calculate Square

Create:

public int Square(int number)

Return the square.*/

    public double CalculateSquare(int number)
    {
        return number * number;
    }
    /*12. Check Pass or Fail

Create:

public string CheckResult(int marks)

Rules:

50 or above → "Pass"
Below 50 → "Fail"

Return the result.*/
    public string CheckResult(int marks)
    {
        if (marks >= 50)
        {
            return "Pass";
        }


        return "Fail";
    }
    /*ind Largest Number

Create:

public int FindLargest(int a, int b, int c)

Return the largest of the three numbers.

Example:

10, 25, 15

Largest: 25

Practice: parameters + return + conditions.*/
    public int FindLargest(int a, int b, int c)
    {
        if ((a >= b && a >= c))
        {
            return a;
        }
        else if ((b >= a && b >= c))
        {
            return b;
        }
        else if ((c >= a && c >= b))
        {
            return c;
        }
        return 0;
    }

    /*Calculate Discount

    Create:

    public double CalculateDiscount(double amount)

    Rules:

    Below ₹500 → 0%
    ₹500–₹999 → 5%
    ₹1000+ → 10%

    Return the discount amount, not the final price.

    Example:

    Amount: 1200
    Discount: 120*/

    public double CalculateDiscount(double amount)
    {
        double discount = 0;

        if (amount < 500)
        {
            //  Console.WriteLine("0% discount");
            return 0;
        }
        else if (amount >= 500 && amount <= 999)
        {
            discount = amount * 5 / 100;
            return discount;

        }
        else if (amount >= 1000)
        {
            discount = amount * 10 / 100;
            return discount;

        }
        else
        {
            Console.WriteLine("Enter valid amount");
            return -0;
        }
    }
    /*
    0. Shopping Cart ⭐

    Create:

    string[] products =
    {
        "Laptop",
        "Mouse",
        "Keyboard",
        "Monitor"
    };

    Create prices:

    Laptop    → 50000
    Mouse     → 1000
    Keyboard  → 2000
    Monitor   → 15000*/
    public void ShoppingCart()
    {
        string userChoice = "";
        do
        {


            string[] products =
    {
    "Laptop",
    "Mouse",
    "Keyboard",
    "Monitor"
};
            double totalAmount = 0;
            int[] price =
           {
    50000,
    1000,
    2000,
    15000
};
            double discount = 0;
            Console.WriteLine("Enter the product name");
            string productName = Console.ReadLine();
            for (int i = 0; i < products.Length; i++)
            {
                if (!products[i].Equals(productName))
                {
                    Console.WriteLine("Product not found!");
                    
                }
                else if (products[i].Equals(productName))
                {
                    Console.WriteLine($"product found ..... {productName} !");

                    Console.WriteLine("enter the Quantity");
                    int quantity = int.Parse(Console.ReadLine());
                    totalAmount = price[i] * quantity;



                    Console.WriteLine($"the total Amount is : {totalAmount} ");
                    Console.WriteLine($"following are the product name and price {products[i]} → {price[i]}");
                    if (totalAmount >= 50000)
                    {
                        discount = totalAmount * 10 / 100;

                    }
                    else if (totalAmount >= 20000)
                    {
                        discount = totalAmount * 5 / 100;


                    }
                    else
                    {
                        Console.WriteLine("No discount");
                    }
                }

                double finalAmount = totalAmount - discount;
                Console.WriteLine($"finalAmount : {finalAmount} discount : {discount}");
                break;
            }


            Console.WriteLine("Enter the user choice");
            userChoice = Console.ReadLine().ToLower();

        }
        while (userChoice == "yes");
        Console.WriteLine("program ended");
    }
    /*
    Scenario — Password Retry

Create a program that repeatedly asks the user for a password.

Correct password:

Admin@123

Rules:

Keep asking until the user enters the correct password.

If correct, print:

Login successful!
Use a while loop.

Example:

Enter password:
hello

Wrong password. Try again.

Enter password:
Admin@123

Login successful!*/
    public void LoggingWithCorrecrPass()
    {
        string userName = "Admin";
        string Password = "";
        while (Password != "Admin@1234")
        {
            Console.WriteLine("Enter password...!");
            Password = Console.ReadLine();
            if (!Password.Equals("Admin@1234"))
            {
                Console.WriteLine(" enters the correct password.");

            }
            else
            {

                Console.WriteLine("Login successful !");

            }

        }
    }
    /* Scenario — Grade Checker

    Ask the user to enter a grade as a single character.

    Enter grade: A

    Rules:

    A → Excellent
    B → Good
    C → Average
    D → Pass
    F → Fail

    Use:

    char grade

    and switch.

    Example:

    Enter grade: A
    Excellent*/
    public void GradeChecker()
    {
        Console.WriteLine("Enter a grade");
        char Grade = char.Parse(Console.ReadLine());
        if (Grade == 'A')
        {
            Console.WriteLine("Excellent");
        }
        else if (Grade == 'B')
        {
            Console.WriteLine("Good");
        }
        else if (Grade == 'C')
        {
            Console.WriteLine("Average");
        }
        else if (Grade == 'D')
        {
            Console.WriteLine("Pass");
        }
        else if (Grade == 'F')
        {
            Console.WriteLine("Fail");
        }
        else
        {
            Console.WriteLine("please enter valid grade");
        }
    }
    /*
    Scenario — Age Verification

    Ask the user for their age.

    Create:

    bool isAdult

    Rules:

    Age >= 18 → true
    Age < 18 → false

    Then print:

    Enter age: 25
    Adult: True

    or:

    Enter age: 15
    Adult: False*/
    public bool AgeVerification()
    {
        Console.WriteLine("Enter Age");
        int Age = int.Parse(Console.ReadLine());
        if (Age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /*
    Scenario — Optional Mobile Number

    Create:

    int? mobileNumber = null;

    Ask the user:

    Do you want to enter your mobile number? yes/no

    If yes, take the number.

    If no, keep it as null.

    :*/
    public void OptionalMobNum()
    {
        long? MobNum = null;
        long? mobNum = null;
        Console.WriteLine("Enter use choice");
        string userChoice = Console.ReadLine().ToLower();
        if (userChoice.Equals("yes"))
        {
            Console.WriteLine("Enter a mobile number");
            MobNum = long.Parse(Console.ReadLine());
            Console.WriteLine($"The value stored as mobilenumber : {MobNum}");

        }
        else
        {
            Console.WriteLine("Mobile number is not mandatory");
        }
        if (MobNum.HasValue)
        {
            Console.WriteLine($"MobileNumber value {MobNum}");

        }
        else
        {
            Console.WriteLine($"MobileNumber doesnot have value {MobNum}");

        }
    }
    /*
    Scenario — Employee Information

    Create variables using var:

    Employee name → "Rahul"
    Employee age → 25
    Salary → 45000.50
    Is active → true

    Your task is to use:

    var employeeName = ...
    var age = ...
    var salary = ...
    var isActive = ...

    Then print all four.

    Example:

    Name: Rahul
    Age: 25
    Salary: 45000.5
    Active: True*/
    public void EnterEmployeeDetails()
    {
        var Age = 25;
        var Salary = 125000;
        var isActive = true;

        Console.WriteLine($"Employee Age : {Age}");
        Console.WriteLine($"Employee Salary per month : {Salary}");
        Console.WriteLine($"is employee Active : {isActive}");
    }

    /*
    Scenario — Changing Data

Create:

dynamic value;

Assign different types one after another:

100
"Hello"
25.5
true*/
    public void ChangingData()
    {
        dynamic value = "hello";
        Console.WriteLine(value);

        value = 78;
        Console.WriteLine(value);

        value = 9.8;
        Console.WriteLine(value);

        value = true;
        Console.WriteLine(value);
    }
/*Scenario — General Information

Create:

object data;

Store:

100
"Hello"
25.5
true

Print each value.

Example:

object data = 100;
Console.WriteLine(data);

data = "Rahul";
Console.WriteLine(data);

data = 25.5;
Console.WriteLine(data);

data = true;
Console.WriteLine(data);*/
public void printInfo()
    {
        Object value="Hello";
                Console.WriteLine(value);

        value=9.8;
                Console.WriteLine(value);

                value=true;
        Console.WriteLine(value);

        value=123;
                Console.WriteLine(value);
    }
    /*
    Scenario — Grade Checker

    Ask the user to enter a grade as a single character.

    Enter grade: A

    Rules:

    A → Excellent
    B → Good
    C → Average
    D → Pass
    F → Fail

    Use:

    char grade

    and switch.

    Example:

    Enter grade: A
    Excellent*/
    public void verifyGradeValue()
    {
        Console.WriteLine("Enter Grade");
        char Grade=char.Parse(Console.ReadLine().ToUpper());
        switch (Grade)
        {
            case 'A':
            Console.WriteLine("Excellent");
            break;
            case 'B':
            Console.WriteLine("Good");
            break;
            case 'C':
            Console.WriteLine("Average");
            break;
            case 'D':
            Console.WriteLine("Pass");
            break;
            case 'F':
            Console.WriteLine("Fail");
            break;
            default:
            Console.WriteLine("the entered Grade is not valid");
            break;
        }
        }
    }



