using System.Dynamic;

namespace MyApp;

public class PassByValueAndPassByReference
{
    /*
    🟢 Pass by Value — Scenario 1
Scenario: Employee Salary

Create a method:

public static void IncreaseSalary(int salary)

Rules:

Starting salary = 30000
Inside the method, increase salary by 5000.
Print the salary inside the method.
Then print the salary again in Main().
Expected structure
int salary = 30000;

IncreaseSalary(salary);

Console.WriteLine($"Salary in Main: {salary}");*/
public static void IncreaseSalary(int salary)
    {
       int incSalary= salary+5000;
        Console.WriteLine($"the salary after increase : {incSalary}");
    }

public static void Withdraw(int balance, int amount)
    {

        balance=balance-amount;
Console.WriteLine($"Balance in Method: {balance}");        
    }
    /*
    🟢 Scenario — Withdraw using ref

Starting balance:

5000

Withdrawal:

1000

Create:

public static void Withdraw(ref int balance, int amount)

Inside the method:

balance = balance - amount;

Print:

Balance in Method: 4000
In Main()

Notice the ref here:

int balance = 5000;

PassByValueAndPassByReference.Withdraw(ref balance, 1000);

Console.WriteLine($"Balance in Main: {balance}");
Expected output
Balance in Method: 4000
Balance in Main: 4000
🧠 Key difference

Pass by value:

Method: 4000
Main:   5000

Pass by reference (ref):

Method: 4000
Main:   4000

Because ref allows the method to work with the original variable, rather than a copy */

public static void Withdraw(out int result, int balance, int amount){
    result=balance-amount;
    Console.WriteLine($"Balance in Method : {balance}");
}

 /*
    🟢 Scenario — Calculate Bill

Create:

public static void CalculateBill(
    int price,
    int quantity,
    out int total,
    out int discount)
Rules

Price:

1000

Quantity:

3

Calculate:

Total = price × quantity
Discount = 10% of total

So:

Total = 3000
Discount = 300
Inside the method

You need to assign both out variables:

total = price * quantity;
discount = total * 10 / 100;
In Main()
int total;
int discount;

CalculateBill(1000, 3, out total, out discount);

Console.WriteLine($"Total: {total}");
Console.WriteLine($"Discount: {discount}");

Expected:

Total: 3000
Discount: 300
🧠 Remember

Here:

price       → input
quantity    → input
total       → output
discount    → output*/

public static void CalculateBill(int price,int quantity,out int total,out int discount)
    {
        total=price*quantity;

    discount=total*10/100;
    Console.WriteLine($"Total: {total}");
Console.WriteLine($"Discount: {discount}");

    }
/*
🟢 Practice Question — Optional Parameter
Scenario: Employee Greeting

Create this method:

public static void GreetEmployee(string name, string department = "IT")
Rules
name is required.
department is optional.
If the user provides the department, print it.
If the user doesn't provide the department, use "IT" automatically.
In Main(), make these two calls:
GreetEmployee("Rahul", "HR");
GreetEmployee("Amit");
Expected output:
Employee: Rahul
Department: HR

Employee: Amit
Department: IT*/

public static void GreetEmployee(string name,string Department="IT")
    {
         Console.WriteLine($"Welcome : {name} in {Department} Department");
    }
public static void DisplayStudent(
    string name,
    int age,
    string course)
    {
        Console.WriteLine($"Name : {name} age : {age} course {course}");
    }
}
public class Student
{
    string  name;
     int age;
    public  void DisplayStudent()
    {
         name = "Jyoti";
         age=25;

         Console.WriteLine($"Name : {name} age : {age}");
    }
/*

🟢 Scenario — Bank Account

Create a class:

public class BankAccount
{
    string accountHolder;
    double balance;
}

These should be instance fields.

Create a method
public void DisplayAccount()

Rules:

accountHolder → "Jyoti"
balance → 50000
Print:
Account Holder: Jyoti
Balance: 50000
In Main()

Create an object:

BankAccount account = new BankAccount();

account.DisplayAccount();*/
public class BankAccount
{
    
    public void DisplayAccount(string accountHolder,
    double balance)
        {
            
            Console.WriteLine($"Account Holder: {accountHolder} Balance : {balance}");
        }
        }
}