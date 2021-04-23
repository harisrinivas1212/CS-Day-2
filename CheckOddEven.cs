using System;

namespace HelloWorld
{
class class2
{
    void CheckOddEven(int a)
    {
        
        if (a%2==0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
    static void Main()
    {
        class2 class1 = new class2();
        class1.CheckOddEven(5);
        Console.ReadLine();
    }
}
}