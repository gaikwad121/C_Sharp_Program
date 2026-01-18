using System;
namespace MyProjectDemo;

public class Program5
{
   public static void string_Method()
    {
        // calculate string length
        string name="Gaikwad";
        int length=name.Length;
Console.WriteLine("The length of the string"+length);
    }
    public static void Conv_Upper_Lower_Char()
    {
        string name="GaiKwaD";
        string upper=name.ToUpper();
        string lower=name.ToLower();
        Console.WriteLine(upper);
        Console.WriteLine(lower);
    }
   public  static void if_Upper_Make_lower_if_capital_Make_Upper()
    {
        string name="GaiKwaD";
                    
        char [] ch=name.ToCharArray();
        for(int i=0;i<ch.Length;i++){
        if (Char.IsLetter(ch[i]))
        {
                if (char.IsUpper(ch[i]))
                {
               ch[i]=  char.ToLower(ch[i]);

                }
               else if (char.IsLower(ch[i]))
                {
               ch[i]= char.ToUpper(ch[i]);
                }
        }
        }
                Console.WriteLine(new string (ch));
        }
        
            
        }
    

