using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    // 1
    public class Person
    {
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;

            if (BirthDate.AddYears(age) > today)
            {
                age--;
            }

            return age;
        }
    }

    // 2
    public class WorkSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }

        public string GetDetailedDuration()
        {
            var duration = GetDuration();
            var totalHours = (int)duration.TotalHours;
            var minutes = duration.Minutes;

            return $"Сессия продлилась: “{totalHours} часа {minutes} минут”";
        }
    }

    // 3
    public class Student(string name, int grade)
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public int Grade { get; set; } = grade;
    }

    // 4
    public class Book(int id, string title, string author)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
    }

    // 5
    class Department(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
    }

    class Employee(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
    }
}
