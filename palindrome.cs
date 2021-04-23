using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string inputstring = Console.ReadLine();
        char []reversedstringArray=new char[inputstring.Length];
        
        for (int i = inputstring.Length-1; i>=0; i--)
        {
            reversedstringArray[i] = inputstring[i];
        }
        string reversedstring = new string(reversedstringArray);
        if(reversedstring == inputstring)
        {
            Console.WriteLine("Palindrome");
        }
        else 
        {
            Console.WriteLine("Not Palindrome enter a new string");
        }
        Console.ReadLine();
    }
}