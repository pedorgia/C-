
using HomeWork12;

class Program
{
    static void Main()
    {
        // 1
        Person person = new("Яна", 27, "yanochka@gmail.com", true);
        ReflectionTest.PrintProperties(person);

        // 2
        var inputPath = "input.txt";
        var outputPath = "output.txt";
        File.WriteAllLines(inputPath, ["Авокадо", "Манго", "Сыр", "Яйца"]);

        var lineCount = 0;
        var charCount = 0;
        List<string> lines = [];
        using (StreamReader reader = new(inputPath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                lineCount++;
                charCount += line.Length;
                lines.Add(line);
            }
        }

        using StreamWriter writer = new(outputPath);
        writer.WriteLine($"Количество строк: {lineCount}");
        writer.WriteLine($"Количество символов: {charCount}");
        writer.WriteLine("Содержимое: ");

        foreach (var line in lines)
        {
            writer.WriteLine(line);
        }
    }
}