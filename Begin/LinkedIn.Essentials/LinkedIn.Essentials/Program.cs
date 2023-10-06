// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Employee e = new Employee("Abel", "Mhlanga");
Console.WriteLine($"From {e.FirstName}, Hello world");

Employee e1 = new Employee
{
    FirstName = "Albert",
    LastName = "May";
    StartDate = new DateOnly(2012, 2, 20);
    Console.WriteLine($"From {e1.FirstName}, Hello World");

}