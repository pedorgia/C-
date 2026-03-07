using HomeWork4;

class Program
{
    static void Main()
    {
        // 1
        Person person = new()
        {
            Name = "Яна",
            BirthDate = new DateTime(1999, 2, 6)
        };

        Console.WriteLine($"Полных лет: {person.GetAge()}");

        // 2
        WorkSession session = new()
        {
            StartTime = new DateTime(2026, 3, 7, 8, 0, 0),
            EndTime = new DateTime(2026, 3, 7, 10, 30, 0)
        };

        Console.WriteLine(session.GetDetailedDuration());

        // 3
        List<Student> students =
        [
            new("Алексей", 5),
            new("Мария", 3),
            new("Иван", 4),
            new("Елена", 2),
            new("Дмитрий", 5)
        ];
        PrintHighAchievers(students);

        // 4
        Dictionary<int, Book> library = [];

        library.TryAdd(1, new Book(1, "1984", "Джордж Оруэлл"));
        library.TryAdd(2, new Book(2, "Мастер и Маргарита", "Михаил Булгаков"));
        library.TryAdd(3, new Book(3, "Преступление и наказание", "Федор Достоевский"));

        Console.Write("Введите ID книги для поиска: ");
        if (int.TryParse(Console.ReadLine(), out int bookId))
        {
            if (library.TryGetValue(bookId, out Book? foundBook))
            {
                Console.WriteLine($"'{foundBook.Title}', автор: {foundBook.Author}");
            }
            else
            {
                Console.WriteLine("Книга с таким ID не найдена.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }

        // 5
        var employeeInfo = new Dictionary<int, List<Employee>>();

        Department dept1 = new(1, "Отдел кадров");
        Department dept2 = new(2, "Бухгалтерия");

        employeeInfo[dept2.Id] =
        [
            new(101, "Маша"),
            new(102, "Паша")
        ];

        employeeInfo[dept1.Id] =
        [
            new(201, "Саша"),
            new(211, "Даша")
        ];

        Console.Write("Введите ID отдела: ");
        if (int.TryParse(Console.ReadLine(), out int deptId))
        {
            if (employeeInfo.TryGetValue(deptId, out List<Employee>? employees))
            {
                Console.WriteLine($"Сотрудники в отделе {deptId}:");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.Name}, ID: {emp.Id}");
                }
            }
            else
            {
                Console.WriteLine("Отдел не найден.");
            }
        }
    }

    // 3
    static void PrintHighAchievers(List<Student> students)
    {
        var topStudents = students.Where(s => s.Grade >= 4);

        foreach (var student in topStudents)
        {
            Console.WriteLine($"ID: {student.Guid}, имя: {student.Name}, оценка: {student.Grade}");
        }
    }
}