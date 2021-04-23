using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();
        int[] charCount = new int[256];
        int length = inputString.Length;
        for (int index = 0; index < inputString.Length; index++)
        {
            charCount[inputString[index]]++;
        }
        int maxcount = -1;
        char character = ' ';
        for (int i = 0; i < length; i++)
        {
            if(maxcount<charCount[inputString[i]])
            {
                maxcount=charCount[inputString[i]];
                character = inputString[i];
            }
        }
        Console.WriteLine("the string is {0}", inputString);
        Console.WriteLine("The Highest occuring character us is :" +character+" and count is " +maxcount);
        Console.ReadLine();
    }
}