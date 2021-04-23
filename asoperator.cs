using System;

namespace HelloWorld
{
class Employee
{
    public int EmployeeID {get; set; }
    public string Name {get; set;}
}
class Class1
{
    static void Main()
    {
        Employee emp= new Employee();
        emp.EmployeeID = 101;
        emp.Name= "Dummy1";
        Employee emp2 = new Employee();
        emp.EmployeeID = 102;
        emp.Name= "Dummy2";
        string a = "hari";
        string b = "hari";
        Console.WriteLine(a.Equals(b));
        Console.WriteLine(Equals(a,b));
        Console.ReadLine();
    }
}

}