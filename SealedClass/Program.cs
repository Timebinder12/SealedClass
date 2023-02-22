using System;

interface IEmployee
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
    public double Pay();
}
class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}
sealed class Executive : Employee
{
    public string Title { get; set; }
    public int Salary { get; set; }
    public Executive()
        :base()
    {
        Title = string.Empty;
        Salary = 0;
    }
    public Executive(int id, string firstName,string lastName, string title, int salary)
        : base(id, firstName, lastName)
    {
        Title = title;
        Salary = salary;
    }
    public override double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.FirstName} {this.LastName}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Employee employee= new Employee(1, "Scooby", "Doo");
        Console.WriteLine("Information on employees:");
        Console.WriteLine($"First name: {employee.FirstName}");
        Console.WriteLine($"Last name: {employee.LastName}");
        Console.WriteLine($"ID: {employee.Id}");

        Executive executive= new Executive(2, "Scrappy", "Doo", "Manager", 2000);
        Console.WriteLine("Information on Executives:");
        Console.WriteLine($"First name: {executive.FirstName}");
        Console.WriteLine($"Last name: {executive.LastName}");
        Console.WriteLine($"ID: {executive.Id}");
        Console.WriteLine($"Title: {executive.Title}");
        Console.WriteLine($"Salary: {executive.Salary} scooby snacks");
    }
}