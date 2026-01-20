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

// in trim we have diffrent methods like a trim start with trim end with 
public static void trimFunctions()
    {
        string para ="     this is a golden chance to focus on your career and your work dont waste your time        ";
        string startSpace=para.TrimStart();
        Console.WriteLine("using the TrimStart we can trim the strating spaces in a line "+startSpace);
        string endSpace=para.TrimEnd();
                Console.WriteLine("using the TrimStart we can trim the strating spaces in a line "+endSpace);
               


    }


// substring  this will gave you the substring of a string(word) we will not get by character
// the output of a follwoing code is : jyoti
public static void substringConcept()
    {
        string sub="hello jyoti Mahadev gaikwad how are you how is your prepartion going buddy";
        string con=sub.Substring(6,6);
        Console.WriteLine(con);
    }
    // we use split method in string for separting a word from sentaces 
// ex : hello, jyoti,mahadev ,gaikwad,how ,are 
    public static void checkWordEvenOdd()
    {
        string sub="hello jyoti Mahadev gaikwad how are you how is your prepartion going buddy";
        string [] words=sub.Split(" ");
        string evenword;
        string oddWord;
        foreach(string word in words)
        {
            int length=word.Length;
            if (length % 2 == 0)
            {
                evenword=word;
                Console.Write("the word are even : ");
                Console.WriteLine(evenword+" ");
            }
            else
            {
                oddWord=word;
                Console.Write("the word are odd : ");
                Console.WriteLine(oddWord+" ");
            }
        }
    

    }


// string formating : we use the string formating for like if want print : pleasen check following code exmaple for this

public static void string_Formating()
    {
       string name="jyoti";
       int age=25;
       long salary=123467;
       Console.WriteLine("Hi ! {0} your age is {1} and your per month salary is {2:c}",name,age,salary) ;
    }}