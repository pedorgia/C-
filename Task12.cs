using System;

// 1
public record Employee1(string Name, int Id, string Department);
// 2
public record Employee2(string Name, int Id, string Department, decimal Salary);

class Task12
{
    static void Main()
    {
        // 1
        var employee1 = new Employee1("Яна", 6, "IT");
        var employee2 = new Employee1("Яна", 6, "IT");

        bool equals = employee1.Equals(employee2);
        bool operatorEquals = (employee1 == employee2);

        Console.WriteLine($"Результат .Equals - {equals}");
        Console.WriteLine($"Результат == - {operatorEquals}");

        // 2
        var employee = new Employee2("Яна", 215, "IT", 1000);

        decimal bonus = 500;
        Employee2 promotedEmployee = Promote(employee, bonus);

        Console.WriteLine("Cотрудник до повышения:");
        Console.WriteLine(employee);

        Console.WriteLine("Сотрудник после повышения:");
        Console.WriteLine(promotedEmployee);
    }
    // 2
    public static Employee2 Promote(Employee2 emp, decimal bonus)
    {
        return emp with { Salary = emp.Salary + bonus };
    }
}

