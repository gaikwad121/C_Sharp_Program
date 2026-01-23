using System.IO.Pipes;

namespace MyProjectDemo;

public class math_Method
{
    public static void test1()
    {
        Console.WriteLine(Math.E);
        Console.WriteLine(Math.PI);
        double pi=456.7;
        Console.WriteLine(Math.Round(pi));
        Console.WriteLine(Math.Floor(pi));
        Console.WriteLine(Math.Ceiling(pi));
        Console.WriteLine(Math.Clamp(10,0,15));
        Console.WriteLine(Math.Clamp(-2,0,8));
        Console.WriteLine(Math.Clamp(4,5,10));
        // Abs its gave absolute value like if we gave -14 it will gave a 14
        Console.WriteLine(Math.Abs(-34));
        // We have the 
    }
}
