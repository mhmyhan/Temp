// See https://aka.ms/new-console-template for more information

using EmployeeManager;

// Create an employee object
var em1 = new Employee("John Doe", "SE1", 34);

// TESTING ->

// write to console
Console.WriteLine(em1.ToString());

var em2 = createEmployee();

em2.getWageString();

Console.WriteLine(em2.ToString());

// testing END //

// Keep the console open
Console.ReadLine();


// top level methods
Employee createEmployee()
{
    Console.Write("Enter full name: ");
    String empName = Console.ReadLine();
    Console.Write("Enter ID: ");
    String empID = Console.ReadLine();
    Console.Write("Enter hours worked: ");
    int hrsWorked = Convert.ToInt32(Console.ReadLine());
    
    return new Employee(empName, empID, hrsWorked);
}