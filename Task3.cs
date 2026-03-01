using System;
using System.Threading.Tasks;
class Program
{
    // 3
    static async Task Main()
    {
        Task<string> taskA = GetDataAsync("Задержка 3000", 3000);
        Task<string> taskB = GetDataAsync("Задержка 1000", 1000);

        Task<string> completedTask = await Task.WhenAny(taskA, taskB);

        string result = await completedTask;
        Console.WriteLine($"Победитель: {result}");
    }

    public static async Task<string> GetDataAsync(string sourceName, int delayMs)
    {
        await Task.Delay(delayMs);
        return $"Данные от {sourceName}";
    }
}
