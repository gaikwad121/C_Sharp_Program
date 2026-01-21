using System.Globalization;

namespace MyProjectDemo;

public class star_Pattern
{
   private static int num=5;
    public static int  inputValue()
    {
        Console.WriteLine("Enter any number");
            int num=int.Parse(Console.ReadLine());
return num;
    }
    /* ouput :

*
* *
* * *
* * * *
=========================================================================================================================================
*/
    public static void triangle_Pattern()
    {
        for(int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

/* output 

* * * *
* * *
* *
*
===========================================================================================================================================
*/
public static void invert_Triangle()
    {
        for(int i = num; i >= 0; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

/* Output

1
1 2
1 2 3
1 2 3 4

=========================================================================================================================================================================================================
*/
public static void Num_Traingle()
    {
        for(int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    
    /* Output

1
2 2
3 3 3
4 4 4 4
========================================================================================================================================
*/
public static void num_Triangle()
    {
        for(int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }

    /* Output

1
2 1
3 2 1
4 3 2 1

==================================================================================================================================================================
*/
    
    public static void number_Triangle()
    {
        for(int i = 1; i <= num; i++)
        {
            for(int j = i; j>=1; j--)
            {
                Console.Write(j);
            }
        
            Console.WriteLine();
        }
        
    }
    /* Output 

1
2 3
4 5 6
7 8 9 10
=========================================================================================================================================================================================
*/
public static void Number_Triangle()
    {
        int count=1;
        for(int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(count+" ");
                count++;
            }
            Console.WriteLine();
        }
    }

    /*

    *
  * * *
 * * * * *
  * * *
   *
=================================================================================================================================================================================
*/
public static void star_Diamond()
    {
        for(int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(int i = num-1; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

/*

* * * * *
  * * * *
    * * *
      * *
        *
==================================================================================================================================================================================================================================
*/
public static void inv_Triangle()
    {
        int num=5;
        for(int i = num; i >=1; i--)
        {
        for(int j = 1; j <= num - i; j++)
            {
                Console.Write(" ");
            }
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

/*

*
* *
*   *
*     *
* * * * *

====================================================================================================================================================================================
*/
public static void Inv_Triangle()
    {
        int num=5;
        for(int i = 1; i <=num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(i==j || j == 1 || i==num)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
                Console.WriteLine();
            }
        }
    }

