using System;

namespace HelloWorld
{
  public struct person
    {
        public string Name { get; set; }
        
        public person(string _name)
        {
            Name = _name;
        }
    }
    
    public struct Dog 
    {
        public string Breed { get; set; }
        
        public Dog(string _breed)
        {
            Breed = _breed;
        }
    }
    class class4
    {
        public static void showvalue(object o)
        {
            if(o is person p)
            {
                Console.WriteLine(p.Name);
            }
            else if(o is Dog d)
            {
                Console.WriteLine(d.Breed);
            }
            
        }
        static void Main()
        {
            object o = new person("hari");
            showvalue(o);
            o = new Dog("Husky");
            showvalue(o);
            Console.ReadLine();
        }
    }
}
