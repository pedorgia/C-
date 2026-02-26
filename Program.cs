using HomeWork3;

class Program
{
    static void Main()
    {
        // 4
        int x = 22;
        int y = 2;

        int resAdd = MathHelper.Add(x, y);
        int resSubtract = MathHelper.Subtract(x, y);
        int resMultiply = MathHelper.Multiply(x, y);

        Console.WriteLine($"x: {x}, y: {y}");
        Console.WriteLine($"Сумма: {resAdd}");
        Console.WriteLine($"Разность: {resSubtract}");
        Console.WriteLine($"Произведение: {resMultiply}");

        // 5
        FileStorage fileStorage = new();
        MemoryStorage memoryStorage = new();

        string myData = "инфа";

        fileStorage.Save(myData);
        memoryStorage.Save(myData);

        // 8
        Shape[] shapes = new Shape[]
        {
            new Rectangle(10, 5),
            new Circle(7),
            new Rectangle(3, 4)
        };
        foreach (var shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"{shape.GetType().Name} - {area}");
        }
    }
}
