using System;

namespace HelloWorld
{
class Dog
{
    public void Speak()
    {
        Console.WriteLine("Bark !");
    }
}
class Class1
{
    static void Main()
    {
        Object o = new Dog();
        Dog dog = o as Dog;
        if (dog !=null)
            dog.Speak();
        Console.ReadLine();
    }
}

}