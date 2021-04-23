using System.IO;
using System;

class class4
{
    static void Main()
    {
        int result;
        
        int.TryParse(" 123 ",out result);
        Console.WriteLine(result);
        if(result == 0)
        {
            Console.WriteLine("Not a Number");
        }
        else
        {
            Console.Write("Number");
        }
        
        Console.ReadLine();
    }
}