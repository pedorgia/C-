
namespace HomeWork3
{
    // 1
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceFromZero()
        {
            return Math.Sqrt(X*X + Y*Y);
        }
    }
    // 4
    public static class MathHelper
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;
    }
    // 5
    interface IStorage
    {
        void Save(string data);
    }

    class FileStorage : IStorage
    {
        public void Save(string data)
        {
            Console.WriteLine($"{data} - Данные сохранены в файл");
        }
    }

    class MemoryStorage : IStorage
    {
        public void Save(string data)
        {
            Console.WriteLine($"{data} - Данные сохранены в память");
        }
    }
    // 6
    class StepCounter
    {
        private int _steps;

        public void AddSteps(int count)
        {
            if (count > 0)
            {
                _steps += count;
            }
        }

        public int GetSteps()
        {
            return _steps;
        }

        public void Reset()
        {
            _steps = 0;
        }
    }
    // 7
    class Transport
    {
        public int Speed { get; set; }
        public string Name { get; set; }

        public Transport(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется");
        }
    }

    class Car : Transport
    {
        public Car(int speed) : base("Машина", speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} едет со скоростью {Speed} км/ч");
        }
    }

    class Bicycle : Transport
    {
        public Bicycle(int speed) : base("Велосипед", speed) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} едет со скоростью {Speed} км/ч");
        }
    }
    // 8
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
