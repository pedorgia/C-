namespace homeWork2
{
    // Калькулятор площадей(!!)
    // Создайте класс GeometryHelper с методами:
    // double CircleArea(double radius)
    // double RectangleArea(double a, double b)

    internal class GeometryHelper
    {
        public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double RectangleArea(double a, double b)
        {
            return a * b;
        }
    }

    // Прямоугольник(!!)
    // Класс Rectangle с автосвойствами Width, Height.Методы:
    // GetArea() → площадь
    // GetPerimeter() → периметр
    // IsSquare() → является ли квадратом

    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width*Height; 
        }

        public int GetPerimeter()
        {
            return (Width + Height) * 2;
        }

        public bool IsSquare()
        {
            return Width==Height; 
        }
    }

    // Класс Student с автосвойствами Name,Group, Gpa(средний балл).Добавьте метод IsExcellent() → true, если Gpa >= 4.5.
    internal class Student
    {
        public string Name { get; set; }
        public int Group {  get; set; }

        public double Gpa { get; set; }

        public bool IsExcellent()
        {
            return Gpa >= 4.5;
        }
    }

    // Создайте класс Book с автосвойствами: Title, Author, Year, Pages.Добавьте:
    // конструктор
    // метод GetInfo() → "Ядро и IPS (Л.Н. Лазарев, 1869)"

    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public uint Year { get; set; }
        public uint Pages { get; set; }

        public Book(string title, string author, uint year, uint pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"{Title} ({Author}, {Year})";
        }
    }
    

}
