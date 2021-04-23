using System;

namespace HelloWorld
{
class Class3

{

    void Swap(out int a)
    {
      
     Console.WriteLine(" Inside swap fun");
     a = 6;
        
    }
   
    static void Main()
    {
        Class3 Class1 = new Class3(); 
        int a=5;
        Class1.Swap(out a);
         Console.WriteLine("Inside Main fun");
        Console.WriteLine("a= "+a);
       
        Console.ReadLine();
    }   
}

}