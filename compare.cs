using System;

namespace HelloWorld
{
class Program
{
    static void Main()
    {
        string sample = " Dummy ";
        string sample1 = "Dummy";
        Console.WriteLine(string.Compare(sample,sample1));
        Console.WriteLine(sample.Trim());
        Console.WriteLine(sample.ToLower());
        Console.ReadLine();
    }
}

}