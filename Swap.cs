using System;

namespace HelloWorld
{
class class2
{
    void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Inside Swap");
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
    }
    static void Main()
    {
        class2 class1 = new class2();
        int a = 5, b = 6;
        class1.Swap(a,b);
        Console.WriteLine("Inside Main");
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
        Console.ReadLine();
    }
}
}