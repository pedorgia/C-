// See https://aka.ms/new-consousing HomeWork5;
using HomeWork5;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1
        List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };
        List<int> result = numbers
            .Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .Select(n => n * 3)
            .ToList();
        Console.WriteLine(string.Join(", ", result));

        // 2
        List<Product> products = new()
        {
            new Product { Name = "Хлеб", Price = 25.0, Quantity = 10 },
            new Product { Name = "Смартфон", Price = 15000.0, Quantity = 2 },
            new Product { Name = "Кофеварка", Price = 4500.0, Quantity = 5 },
            new Product { Name = "Шоколад", Price = 120.0, Quantity = 20 },
            new Product { Name = "Спички", Price = 5.0, Quantity = 100 }
        };
        List<string> productNames = products
            .Where(p => p.Price > 100)
            .OrderByDescending(p => p.Price)
            .Select(p => p.Name).ToList();
        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }

        // 3
        List<Student> students = new()
        {
            new Student { Grade = 5 },
            new Student { Grade = 4 },
            new Student { Grade = 3 },
            new Student { Grade = 5 },
            new Student { Grade = 2 }
        };
        var a = students.Any(s => s.Grade < 3);
        var b = students.All(s => s.Grade >= 4);
        var c = students.Count(s => s.Grade > 4);

        // 4
        List<int> arr4 = new() { 5, 12, 7, 20, 33, 18, 2, 40 };
        var evenSum = arr4
            .Where(n => n % 2 == 0)
            .Sum();
        var maxNumber = arr4.Max();
        var averageValue = arr4.Average();

        // 5
        List<int> arr5 = [5, 12, 7, 20, 33, 18, 2, 40];
        var groups = arr5.GroupBy(n => n % 2 == 0 ? "Чётные" : "Нечётные");
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
        }

        // 6
        List<Person> people = new()
        {
            new Person { Name = "Анна", Age = 17 },
            new Person { Name = "Борис", Age = 25 },
            new Person { Name = "Виктор", Age = 15 },
            new Person { Name = "Дарья", Age = 30 },
            new Person { Name = "Егор", Age = 20 }
        };
        var arr6 = people
            .Where(p => p.Age > 18)
            .OrderBy(p => p.Age)
            .Select(p => p.Name);
        foreach (var name in arr6)
        {
            Console.WriteLine(name);
        }

        // 7
        var person = people.FirstOrDefault(p => p.Age > 30);
        if (person != null)
        {
            Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
        }
        else
        {
            Console.WriteLine("Такого не существует");
        }

        // 8
        var res25 = people.Any(p => p.Age < 25);
        var res18 = people.All(p => p.Age > 18);

        // 9
        List<string> words = new() { "Artem", "Natali", "Yana", "Yulia", "Alex" };
        var filteredWords9 = words
            .Where(w => w.Length > 4)
            .OrderBy(w => w);
        foreach (var word in filteredWords9)
        {
            Console.WriteLine(word);
        }

        // 10
        List<string> filteredWords10 = words
            .Where(w => w.Contains("a"))
            .Select(w => w.ToUpper())
            .ToList();

        // 11
        List<int> arr11 = new() { 5, 2, 8, 5, 2, 10, 1, 8 };
        List<int> uniqueSortedNumbers = arr11
            .Distinct()
            .OrderByDescending(n => n)
            .ToList();

        // 12
        List<Order> orders = new()
        {
            new Order { Id = 1, Prices = new List<int> { 100, 500, 300 } },
            new Order { Id = 2, Prices = new List<int> { 1500, 200, 700 } }
        };
        List<int> allPrices = orders
            .SelectMany(o => o.Prices)
            .ToList();
        var maxPrice = allPrices.Max();

        // 13
        User user = new() { Name = "Дмитрий", Age = 28 };
        Action<User> printUserInfo = u =>
        {
            Console.WriteLine($"Имя: {u.Name}, Возраст: {u.Age}");
        };
        printUserInfo(user);

        // 14
        Action<string> printUpper = s => Console.WriteLine(s.ToUpper());
        string message = "Hello Artem!";
        printUpper(message);

        // 15
        Func<double, double, double> getAverage = (x, y) => (x + y) / 2;
        var n1 = 10.5;
        var n2 = 25.5;
        var result15 = getAverage(n1, n2);
        Console.WriteLine(result15);
    }
}
