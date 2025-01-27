using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(int empID, string name, int age, string gender, double salary)
    {
        EmpID = empID;
        Name = name;
        Age = age;
        Gender = gender;
        Salary = salary;
    }
}

class ProgramForEmployee
{
    public static void Main(String[] args)
    {
        // List of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Alice Kashyap", 28, "Female", 50000),
            new Employee(102, "Bob Garg", 35, "Male", 70000),
            new Employee(103, "Charlie", 30, "Male", 60000),
            new Employee(104, "Diana Garg", 26, "Female", 55000),
            new Employee(105, "Eva Kashyap", 31, "Female", 65000),
            new Employee(106, "Frank", 29, "Male", 58000),
            new Employee(107, "Grace", 27, "Female", 59000),
            new Employee(108, "Helen", 25, "Female", 53000),
            new Employee(109, "Isha", 30, "Female", 64000),
            new Employee(110, "Jack", 24, "Male", 45000)
        };

        // 1. Age greater than 25
        var ageGreaterThan25 = employees.Where(e => e.Age > 25).ToList();
        Console.WriteLine("-- Age > 25 --");
        foreach (var employee in ageGreaterThan25)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 2. All female employees
        var allFemale = employees.Where(e => e.Gender == "Female").ToList();
        Console.WriteLine("-- All Female Employees --");
        foreach (var employee in allFemale)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 3. Age between 25-30
        var ageBetween25And30 = employees.Where(e => e.Age >= 25 && e.Age <= 30).ToList();
        Console.WriteLine("-- Age Between 25 and 30 --");
        foreach (var employee in ageBetween25And30)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 4. All female employees whose ID is between 103 and 106
        var femaleWithIDInRange = employees.Where(e => e.Gender == "Female" && e.EmpID >= 103 && e.EmpID <= 106).ToList();
        Console.WriteLine("-- Female Employees with ID between 103 and 106 --");
        foreach (var employee in femaleWithIDInRange)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 5. Employee whose name is "Eva Kashyap"
        var candidateWithNameEva = employees.Where(e => e.Name == "Eva Kashyap").ToList();
        Console.WriteLine("-- Employee Name is 'Eva Kashyap' --");
        foreach (var employee in candidateWithNameEva)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 6. Employee whose age is 30
        var ageIs30 = employees.Where(e => e.Age == 30).ToList();
        Console.WriteLine("-- Employees Age is 30 --");
        foreach (var employee in ageIs30)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 7. Employee name starts with "A"
        var nameStartsWithA = employees.Where(e => e.Name.StartsWith("A")).ToList();
        Console.WriteLine("-- Employee Name Starts with 'A' --");
        foreach (var employee in nameStartsWithA)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 8. Name containing "Garg" in emailID (simulated by Name field)
        var nameContainsGargInEmail = employees.Where(e => e.Name.Contains("Garg")).ToList();
        Console.WriteLine("-- Name Contains 'Garg' --");
        foreach (var employee in nameContainsGargInEmail)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 9. Name having "Kashyap"
        var nameHasKashyap = employees.Where(e => e.Name.Contains("Kashyap")).ToList();
        Console.WriteLine("-- Name Contains 'Kashyap' --");
        foreach (var employee in nameHasKashyap)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 10. Name contains "ya"
        var nameContainsYa = employees.Where(e => e.Name.Contains("ya")).ToList();
        Console.WriteLine("-- Name Contains 'ya' --");
        foreach (var employee in nameContainsYa)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();

        // 11. Age is either 25, 30, or 35
        var ageIs25Or30Or35 = employees.Where(e => e.Age == 25 || e.Age == 30 || e.Age == 35).ToList();
        Console.WriteLine("-- Age is 25, 30, or 35 --");
        foreach (var employee in ageIs25Or30Or35)
        {
            Console.WriteLine("EmpID: " + employee.EmpID + ", Name: " + employee.Name + ", Age: " + employee.Age + ", Gender: " + employee.Gender + ", Salary: " + employee.Salary);
        }
        Console.WriteLine();
    }
}
