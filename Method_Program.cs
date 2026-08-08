using System;
namespace MyApp;
#pragma warning disable
public class Method_Program
{
    public static void Main()
    {
        
        Greet();
Console.WriteLine("Enter marks");
int sql=int.Parse(Console.ReadLine());
int CSharp=int.Parse(Console.ReadLine());
int Selenium=int.Parse(Console.ReadLine());
int total=CalculateTotal(sql,CSharp,Selenium);

Console.WriteLine(GetResult(total));
   string [] List=Method_Program.GetProducts();
foreach(string productList in List)
        {
            Console.WriteLine(productList);
        
        }     
    
    }
    /*
    🟢 Scenario 1 — void Method
Greeting

Create:

public void GreetUser()

Rules:

Ask the user for their name.
Print:
Enter your name:
Rahul

Welcome Rahul!

Requirement: The method should return nothing → use void.*/


    public static void GreetUser()
{
    Console.WriteLine("Enter your name");
    string? name = Console.ReadLine();
    Console.WriteLine($"Welcome {name}");
}

/*
🟢 Scenario 2 — int Return Type
Calculate Total

Create:

public int CalculateTotal(int price, int quantity)

Rules:

Take price and quantity as parameters.
Calculate:
price × quantity

Example:

Price: 500
Quantity: 3

Total: 1500

Requirement: Return the total as an int.*/
public static int CalculateTotal(int price, int quantity)
    {
        int total=price*quantity;
        return total;
    }
/*
🟢 Scenario 3 — string Return Type
Get Grade

Create:

public string GetGrade(int marks)

Rules:

90+ → A
75–89 → B
60–74 → C
40–59 → D
Below 40 → F

Example:

Marks: 85
Grade: B

Requirement: The method must return a string, not print the grade directly.*/
public static string GetGrade(int marks)
    {
        if (marks >=90)
        {
            return "A";
        }
        else if(marks >= 75 && marks <= 89)
        {
            return "B";
        }
        else if(marks >= 60 && marks <= 74)
        {
            return "C";
        }
        else if(marks >= 40 && marks <= 59)
        {
            return "D";
        }
        else
        {
            return "F";
        }
        }
    /*
    🟢 Scenario 4 — Array Return Type
Get Products

Create:

public string[] GetProducts()

Return this array:

Laptop
Mouse
Keyboard
Monitor

Then call the method and use a foreach loop to display them.

Expected:

Laptop
Mouse
Keyboard
Monitor

Requirement: The method must return a string[].*/
public static string[] GetProducts()
    {
        string  products=  "Laptop, Mouse, Keyboard, Monitor" ;
        string[] list=products.Split(',');
        
            return list;
        
        }
    //following code in main method
/*    string [] List=Method_Program.GetProducts();
foreach(string productList in List)
        {
            Console.WriteLine(productList);
        
        }*/
        /*
        🟡 Scenario 5 — Combine Everything
Student Information

Create these methods:

public void DisplayStudent()
public int CalculateTotal(int mark1, int mark2, int mark3)
public string GetResult(int total)
public string[] GetSubjects()

Rules:

DisplayStudent()

Print student name.

CalculateTotal()

Return total of 3 marks.

GetResult()

If total >= 120 → "Pass"
Otherwise → "Fail"

GetSubjects()

Return:
C#
SQL
Selenium

This one combines all four return types.

🎯 Do them in order
1️⃣ void       → GreetUser
2️⃣ int        → CalculateTotal
3️⃣ string     → GetGrade
4️⃣ string[]   → GetProducts
5️⃣ Combined   → Student Information*/


    public static void Greet()
    {
        Console.WriteLine("Enter a name");
        string userName=Console.ReadLine();
        Console.WriteLine($"Welcome {userName}");
    }
    public static int CalculateTotal(int mark1,int mark2,int mark3)
    {
        return mark1+mark2+mark3;
    }
public static string GetResult(int total)
    {
        if (total >= 120)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
    public static string[] GetSubjects()
    {
        string subject="C#,Sql,Selenium";
        string [] list=subject.Split(',');

        return list;
    }
    }
