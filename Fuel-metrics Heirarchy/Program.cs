using System;
using System.Collections.Generic;

// Define the Department class
class Department
{
    public string Name { get; set; }
    public Employee HeadOfDepartment { get; set; }

    public Department(string name)
    {
        Name = name;
    }
}

// Define the Employee class
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Department Department { get; set; }
    public string Role { get; set; }

    public Employee(string name, int age, Department department, string role)
    {
        Name = name;
        Age = age;
        Department = department;
        Role = role;
    }
}

// Define the Organization class
class Organization
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }
    public List<Employee> Employees { get; set; }

    public Organization(string name)
    {
        Name = name;
        Departments = new List<Department>();
        Employees = new List<Employee>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        // Create an organization
        Organization organization = new Organization("Fuel Metrics");

        // Create departments
        Department itDepartment = new Department("IT");
        Department salesDepartment = new Department("Sales and Marketing");
        Department frontendDepartment = new Department("Frontend Development");
        Department backendDepartment = new Department("Backend Development");
        Department embeddedSystemsDepartment = new Department("Embedded Systems");
        Department fieldWorkersDepartment = new Department("Field Workers");

        // Add departments to the organization
        organization.AddDepartment(itDepartment);
        organization.AddDepartment(salesDepartment);
        organization.AddDepartment(frontendDepartment);
        organization.AddDepartment(backendDepartment);
        organization.AddDepartment(embeddedSystemsDepartment);
        organization.AddDepartment(fieldWorkersDepartment);

        // Create employees
        Employee employee1 = new Employee("John", 30, itDepartment, "Software Engineer");
        Employee employee2 = new Employee("Mary", 28, itDepartment, "Database Administrator");
        Employee employee3 = new Employee("Mike", 35, itDepartment, "System Analyst");
        Employee employee4 = new Employee("Sarah", 32, itDepartment, "Network Engineer");
        Employee employee5 = new Employee("David", 40, itDepartment, "Head of Department");
        Employee employee6 = new Employee("Emily", 27, itDepartment, "Web Developer");
        Employee employee7 = new Employee("Tiffany", 22, salesDepartment, "Sales Representative");
        Employee employee8 = new Employee("Ajoke", 26, salesDepartment, "Marketing Specialist");
        Employee employee9 = new Employee("Miguel", 32, salesDepartment, "Sales Manager");
        Employee employee10 = new Employee("Janelle", 28, salesDepartment, "Business Development Executive");
        Employee employee11 = new Employee("Leonardo", 40, embeddedSystemsDepartment, "Embedded Systems Engineer");
        Employee employee12 = new Employee("Chunks", 27, embeddedSystemsDepartment, "Firmware Developer");
        Employee employee13 = new Employee("Ismael", 41, embeddedSystemsDepartment, "Head of Department");
        Employee employee14 = new Employee("Tunde", 45, embeddedSystemsDepartment, "Hardware Engineer");
        Employee employee15 = new Employee("Daniel", 32, salesDepartment, "Sales Representative");
        Employee employee16 = new Employee("Ola", 29, frontendDepartment, "Frontend Developer");
        Employee employee17 = new Employee("Blessing", 33, frontendDepartment, "UI/UX Designer");
        Employee employee18 = new Employee("Benson", 31, frontendDepartment, "Frontend Team Lead");
        Employee employee19 = new Employee("Sam", 27, backendDepartment, "Head of department");
        Employee employee20 = new Employee("Gbenga", 34, backendDepartment, "Database Administrator");
        Employee employee21 = new Employee("Tife", 19, backendDepartment, "Backend Team Lead");
        Employee employee22 = new Employee("Alex", 25, embeddedSystemsDepartment, "Embedded Software Engineer");
        Employee employee23 = new Employee("Titi", 26, embeddedSystemsDepartment, "Hardware Designer");
        Employee employee24 = new Employee("Ogun", 29, embeddedSystemsDepartment, "Firmware Developer");
        Employee employee25 = new Employee("Bode", 28, fieldWorkersDepartment, "Head of Department");
        Employee employee26 = new Employee("Evans", 33, fieldWorkersDepartment, "Field Technician");
        Employee employee27 = new Employee("Chuks", 31, fieldWorkersDepartment, "Field Operations Manager");
        Employee employee28 = new Employee("Godwill", 27, fieldWorkersDepartment, "Field Engineer");

        // Add employees to the organization
        organization.AddEmployee(employee1);
        organization.AddEmployee(employee2);
        organization.AddEmployee(employee3);
        organization.AddEmployee(employee4);
        organization.AddEmployee(employee5);
        organization.AddEmployee(employee6);
        organization.AddEmployee(employee7);
        organization.AddEmployee(employee8);
        organization.AddEmployee(employee9);
        organization.AddEmployee(employee10);
        organization.AddEmployee(employee11);
        organization.AddEmployee(employee12);
        organization.AddEmployee(employee13);
        organization.AddEmployee(employee14);
        organization.AddEmployee(employee15);
        organization.AddEmployee(employee16);
        organization.AddEmployee(employee17);
        organization.AddEmployee(employee18);
        organization.AddEmployee(employee19);
        organization.AddEmployee(employee20);
        organization.AddEmployee(employee21);
        organization.AddEmployee(employee22);
        organization.AddEmployee(employee23);
        organization.AddEmployee(employee24);
        organization.AddEmployee(employee25);
        organization.AddEmployee(employee26);
        organization.AddEmployee(employee27);
        organization.AddEmployee(employee28);

        // Display organization details
        Console.WriteLine("Organization: " + organization.Name);
        Console.WriteLine("Departments:");
        foreach (Department department in organization.Departments)
        {
            Console.WriteLine("- " + department.Name);
        }

        Console.WriteLine("Employees:");
        foreach (Employee employee in organization.Employees)
        {
            Console.WriteLine("- Name: " + employee.Name + ", Age: " + employee.Age + ", Department: " + employee.Department.Name + ", Role: " + employee.Role);
        }
    }
}
