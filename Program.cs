// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Linq.Expressions;
using System.Transactions;
using System.Xml.Serialization;

/*Console.WriteLine("Hello, World!");
dynamic v=34;
 v="jyoti";
 v=true;
 Console.WriteLine(v);
 object j=89;
 j="hello";
 Console.WriteLine(j);
 object obj = "Hello";

obj = 100;

Console.WriteLine(obj);
List<int> li=new List<int>()
{
    102,345,789,121,653,102,345,345
};
HashSet<int> d=new HashSet<int>();

foreach(int f in li)
{
    d.Add(f);
}
foreach(int s in d)
{
    Console.WriteLine(s);
}
// Find the sum of even numbers from 1 to N.
Console.WriteLine("Enter the n value");
# pragma warning disable
int n=int.Parse(Console.ReadLine());

int sum=0;
int oddsum=0;
for(int i = 1; i <= n; i++)
{

    if (i% 2 == 0)
    {
        sum+=i;
    }
}
    Console.WriteLine(sum);

    for(int i = 1; i <= n; i++)
{

    if (i% 2 != 0)
    {
        oddsum+=i;
    }
}
    Console.WriteLine(oddsum);

    // Check whether a year is a leap year.
Console.WriteLine("Enter a year" !);
int year=int.Parse(Console.ReadLine());
if((year%4==0 && year % 100 != 0) || year%400==0)
{
    Console.WriteLine($" It's Leap year : {year}");

} 
else
{
    Console.WriteLine($"Not a leap year : {year}");
}
// Find the ASCII value of a character.

char ch='A';
Console.WriteLine($"ASCII value of a character : {(int)(ch)}");

//Convert Celsius to Fahrenheit.
//Find the area of a circle.

//Find the largest element in an array.

int [] arr= {123,67,13,987,231,102,768,231};
int max=int.MinValue;
foreach(int a in arr)
{
    if (a > max)
    {
        max=a;
    }
}
    Console.WriteLine(max);
int [] ar= {123,67,13,987,231,102,768,231};
int min=int.MaxValue;
foreach(int a in arr)
{
    if (a < min)
    {
        min=a;
    }
}
    Console.WriteLine(min);

//Count vowels in a string.

string str="gaikwadJyoti";
int count=0;
char []c=str.ToCharArray();
for(int i = 0; i < c.Length; i++)
{
    char d1=c[i];
    if(d1=='a' || d1=='i' || d1=='o' || d1=='e' || d1=='u' || d1=='A' || d1=='I' || d1=='O' || d1=='E' || d1 == 'U')
    {
        count++;
    }
}
Console.WriteLine(count);

//Reverse a string without using built-in methods.

string name="gaikwad";
string rev="";
for(int i = name.Length-1; i >= 0; i--)
{
    rev=rev+name[i];
}
Console.WriteLine(rev);
// Remove duplicate characters from a string.

string dup="ggaiikwadd";
char [] b=dup.ToCharArray();

HashSet<char> has=new HashSet<char>();
foreach(char g in b)
{
    has.Add(g);
}
foreach(char m in has)
{
    Console.Write(m);
}
//Print numbers 1-20 except multiples of 3.

for(int i = 1; i <= 20; i++)
{
    if (i % 3 != 0)
    {
        Console.WriteLine(i);
    }
}
//Print numbers from 1 to 10 using do-while.
 int num=1;
do
{
    Console.WriteLine("values" + num);
            num++;

}
    while (num <= 10);
    
    
    // Calculator using switch-case.
    int n=int.Parse(Console.ReadLine());
    int a=int.Parse(Console.ReadLine());
   int b=int.Parse(Console.ReadLine());


switch (n)
{
    case 1 : 
    Console.WriteLine(a+b);
    break;
    case 2 : 
    Console.WriteLine(a-b);
    break;
    case 3 : 
    Console.WriteLine(a*b);
    break;
    case 4 : 
    Console.WriteLine(a/b);
    break;
    case 5 : 
    Console.WriteLine(a%b);
    break;
}
// Grade system using if-else.
string choice = "";

do
{
    Console.WriteLine("Enter the marks:");
    int marks = int.Parse(Console.ReadLine());

    if (marks >= 95)
    {
        Console.WriteLine("A++");
    }
    else if (marks >= 85)
    {
        Console.WriteLine("A");
    }
    else if (marks >= 75)
    {
        Console.WriteLine("B++");
    }
    else if (marks >= 65)
    {
        Console.WriteLine("B");
    }
    else if (marks >= 55)
    {
        Console.WriteLine("C");
    }
    else if (marks >= 40)
    {
        Console.WriteLine("PASS");
    }
    else
    {
        Console.WriteLine("FAIL");
    }

    Console.WriteLine("Do you want to continue checking grades? (yes/no)");
    choice = Console.ReadLine().ToLower();

} while (choice == "yes");

Console.WriteLine("Program ended."); 
//Prime number check.
string Continue="";
    

do
{
    Console.WriteLine("Enter a value");
bool isprime=true;
    int num=int.Parse(Console.ReadLine());
    if (num <= 1)
    {
        isprime=false;
    }else{
      for(int i = 2; i <= num/2; i++)
    {
        if (num % 2 == 0)
        {
 isprime=false; 
 break;
        }
    } 

    }
        if (isprime)
        {
            Console.WriteLine("Number is prime");
        }
        else
        {
            Console.WriteLine("Number is not prime");
        }
             Console.WriteLine("Do you want to continue? (yes/no)");
    Continue = Console.ReadLine().ToLower();
        }
        while(Continue=="yes");
        Console.WriteLine("Find primenumbers no need to find more");
    

//Fibonacci series.
    string choice="";

do{
int a=0; int b=1;
Console.WriteLine("Enter any number");
int num=int.Parse(Console.ReadLine());

for(int i = 0; i < num; i++)
{
    Console.WriteLine(a + " ");
    int c=a+b;
       a=b;
       b=c;
}
       Console.WriteLine("do you want to continue");
choice=Console.ReadLine().ToLower();

}while(choice=="yes");
Console.WriteLine("End program");

//Factorial of a number.
string choice="";
do
{
    Console.WriteLine("Enter any number");
    int factorial=1;
    int num=int.Parse(Console.ReadLine());
    for(int i = 1; i <= num; i++)
    {
        factorial=factorial*i;
    }
    Console.WriteLine(factorial);
    Console.WriteLine("Enter your choice");
    choice=Console.ReadLine();
    
}while(choice=="yes");
Console.WriteLine("Program End");

//Reverse a number.Palindrome number.

string choice="";
do
{
    Console.WriteLine("Enter any string");
    string str=Console.ReadLine();
    string rev="";
    for(int i = str.Length - 1; i >= 0; i--)
    {
        rev=rev+str[i];
    }
    if (str == rev)
    {
        Console.WriteLine("It's Palindrome");
    }
    else
    {
                Console.WriteLine("It's not Palindrome");

    }
    Console.WriteLine("Do you want to continue !");
    choice=Console.ReadLine();
}
    while(choice=="yes");
    Console.WriteLine("end the program");



//Armstrong number.
 int  rem, sum = 0, temp=0;

string choice="";
do
{
           
    Console.WriteLine("Enter any number");
    int num=int.Parse(Console.ReadLine());
    while (num > 0)
        {
            rem = num % 10;
            sum = sum + (rem * rem * rem);
            num = num / 10;
        }

        if (temp == sum){
            Console.WriteLine("Armstrong Number");}
        else{
            Console.WriteLine("Not an Armstrong Number");
        }
    Console.WriteLine("ENter you choice");
    choice=Console.ReadLine();
}while(choice=="yes");
Console.WriteLine("Program Ended");

// Sum of digits.

int sum=0;
string choice="";
do
{
    Console.WriteLine("Enter any number");
    int num=int.Parse(Console.ReadLine());
    while (num >0)
    {
        sum+=num%10;
        num/=10;
    }
   
 Console.WriteLine(sum);
 Console.WriteLine("Enter your choice");
 choice=Console.ReadLine();
}while(choice=="yes");
Console.WriteLine("Program Ended");
//Multiplication table.

string choice = "";

do
{
    Console.WriteLine("Enter any number");
    int num = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {

        Console.WriteLine($"{num}*{i} = {num * i}");
    }
    Console.WriteLine("Enter your choice");
    choice = Console.ReadLine();
} while (choice == "yes");
Console.WriteLine("Program Ended");
// Largest of three numbers.
string choice="";
do
{
    Console.WriteLine("Enter a value");
    int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());

    int c=int.Parse(Console.ReadLine());
    if (a > b && a>c )
    {
        Console.WriteLine("A is greater");
    }
    else if (b > c && b>a)
    {
         Console.WriteLine("B is greater");
    }
    else if (c>b && c>a)
    {
         Console.WriteLine("C is greater");
    }
    else
    {
        Console.WriteLine("All are same");
    }
    Console.WriteLine("Enter your choice");
    choice=Console.ReadLine();
}
    while(choice=="yes");
    Console.WriteLine("Program Ended");

//Even/Odd checker.
string choice="";
do
{
    Console.WriteLine("Enter any number");
    int num=int.Parse(Console.ReadLine());
    
        if (num % 2 == 0)
        {
            Console.WriteLine($"It's Even : {num}");
        }
        else
        {
            Console.WriteLine($"It's Odd : {num}");
        }
    
    Console.WriteLine("Enter your choice");
    choice=Console.ReadLine();   
}while(choice=="yes");
Console.WriteLine("End the program");
//Leap year checker.
string choice="";

do
{
    Console.WriteLine("Enter the year");
    int year=int.Parse(Console.ReadLine());
    if((year%4==0 && year % 100 != 0) ||year% 400==0)
    {
        Console.WriteLine($"It's a Leap Year {year}");

    }
    else
    {
                Console.WriteLine($"It's not a Leap Year {year}");

    }
    Console.WriteLine("Enter your choice");
    choice=Console.ReadLine();

}while(choice=="yes");
Console.WriteLine("Program ended");
// Array maximum and minimum.
int [] arr={10
,20,
30,
40,
50};

int max=int.MinValue;

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max=arr[i];
    }
}Console.WriteLine(max);
int [] arr={10
,20,
30,
40,
50};

int min=int.MaxValue;

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min=arr[i];
    }
}Console.WriteLine(min);
*/
// Count vowels in a string.
string choice="";
do{
    Console.WriteLine("Enter any string");
string name=Console.ReadLine();
int count=0;
char []ch=name.ToCharArray();
for(int i=0;i<ch.Length;i++){
char chh=ch[i];
if(chh=='A' || chh=='E' || chh=='O' || chh=='U' || chh=='I' || chh=='a' || chh=='i' || chh=='e' || chh=='o' || chh == 'u')
    {
        count++;
    }
}
    Console.WriteLine(count);
    Console.WriteLine("Enter your choice");
    choice=Console.ReadLine();
}while(choice=="yes");
Console.WriteLine("Programe Ended");







=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Pratice_Codes
{
	public class Conv_One_Data_To_Other
	{
		public static void code()
		{
			string a = "123";
			int num = int.Parse(a); // num = 123
			//Console.WriteLine(num);
			Console.WriteLine(num.GetType());
		}
	}
}

main
