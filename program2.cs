using System;
using System.Transactions;
namespace CSharp_Practice_Codes;
// for this code i have already gave the 1st integere value for second values u have to gave the value through console input
// ** The Result should be following : sum of integer 14 , double should be 8.0 and the string result should be Jyoti Mahadev Gaikwad
public class DataType
{
	//static void Main(string[] args)
	public static void dem()
	{
		int a = 7;
		Double b = 4;
		string s = "Jyoti";
        Console.WriteLine("Enter the input values on console");
		int a2 = int.Parse(Console.ReadLine());
		Double b2 = Double.Parse(Console.ReadLine());
		string s2 = Convert.ToString(Console.ReadLine());

		int sum = a + a2;
		double sum2 = b + b2;
		string res = s + s2;
		Console.WriteLine(sum);
		//Console.WriteLine(sum2);
		Console.WriteLine((b + b2).ToString("0.0"));

		Console.WriteLine(res);

	}
}
