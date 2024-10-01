namespace EmployeeManager;

public class Employee
{
    // Variables
    public string employeeName { get; set; }

    public string employeeID { get; set; }

    public int hoursWorked { get; set; }

    public double hourlyRate { get; set; }


    // Constructors
    public Employee(String empName, String empID, int hrsWorked)
    {
        employeeName = empName;
        
        employeeID = empID;
        hoursWorked = hrsWorked;
        hourlyRate = 9.5;
    }

    // Methods

    public override string ToString()
    {
        return $"{employeeName}({employeeID})" +
               $"\nWage: {getWageString()}";
    }

    public String getWageString()
    {
        double wage = hoursWorked * hourlyRate;
        return $"{wage:C}";
    }

    
}