using System;

// Create an Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects by their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (ReferenceEquals(employee1, employee2))
        {
            return true;
        }

        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
        {
            return false;
        }

        return employee1.Id == employee2.Id;
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        Employee employee2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the two Employee objects using the overloaded "==" operator
        bool areEqual = employee1 == employee2;

        // Display the result of the comparison
        if (areEqual)
        {
            Console.WriteLine("The two employees have the same Id.");
        }
        else
        {
            Console.WriteLine("The two employees have different Ids.");
        }
    }
}

