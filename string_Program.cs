using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
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
    public static void string_Replace()
    {
        string name="jyMti";
        string name_Rep=name.Replace('M','o');
        Console.WriteLine(name_Rep);
        
    }
    public static void insert_String()
    {
        string name= "Mahadev Gaikwad";
        string names=name.Insert(0,"Jyoti");
        Console.WriteLine(names);
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
        public static void startWithEndWith(){
        string [] names={"jyoti","Aishwarya","Sneha","Dharati","Aaradhya","Aaditi","Nanda"};
            foreach(string name in names)
        {
            if (name.StartsWith("A") && !name.Equals("Aishwarya"))
            {
                string child=name;
                        Console.WriteLine("child name is : "+child);

            }
            else if(name.StartsWith("N") && name.EndsWith("a"))
            {
                string Mother=name;
                        Console.WriteLine("Mother name is : "+Mother);

            }
            else
            {
                string sisterName=name;
                        Console.WriteLine("Sister name is :"+sisterName);

            }
        }
        }
public static void trimFun()
    {
      // Original string with extra spaces
        string para = "   this is a golden  chance to   focus on your    work   ";
        
        // Trim removes spaces from start and end
        string trimmedPara = para.Trim();
        Console.WriteLine("After Trim():");
        Console.WriteLine(trimmedPara);

        // Regex to replace multiple spaces inside with a single space
        string cleanedPara = Regex.Replace(trimmedPara, @"\s+", " ");
        Console.WriteLine("\nAfter removing extra spaces between words:");
        Console.WriteLine(cleanedPara);
        }
}

