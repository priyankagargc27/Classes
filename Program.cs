using System;
using System.Collections.Generic;

// Instructions
// Create a custom type for Employee. An employee has the following properties.
// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Title { get; set; }

    public DateTime StartDate { get; set; }
}
// Create a custom type for Company. A company has the following properties.
// Date founded (DateTime)
// Company name (string)
// Employees (List<Employee>)
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; set; }
    public DateTime CreatedOn { get;set;}

    // Create a public property for holding a list of current employees
    public List<Employee> CurrentEmployees = new List<Employee>();

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created
        The constructor will set the value of the public properties
    */
    public Company(string CompanyName, DateTime CompanyFounded)
    {
        Name = CompanyName;
        CreatedOn = CompanyFounded;
    }
    public void ListEmployees(){
        foreach (var Employee in CurrentEmployees)
        {
            //name works for company name as title since employee start date
            Console.WriteLine($"{Employee.FirstName} {Employee.LastName} works for {this.Name} as {Employee.Title} since {Employee.StartDate.ToShortDateString()}");
        }
    }
// The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
}


namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company CHC = new Company("CHC",new DateTime(2010,1,1));
            
            // Create three employees
            Employee One = new Employee(){
                FirstName = "Priyanka",
                LastName = "Garg",
                Title = "Junior Developer",
                StartDate = new DateTime(2018,07,02)
            };

            Employee Two = new Employee(){
                FirstName = "Kaushal",
                LastName = "Goyal",
                Title = "Delivery Manager",
                StartDate = new DateTime(2014,1,1)
            };

           
            // Assign the employees to the company
            CHC.CurrentEmployees.Add(One);
            CHC.CurrentEmployees.Add(Two);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            CHC.ListEmployees();
        }
    }
}