using System;
using System.Xml.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте три переменные с именами score, Score и SCORE. Присвойте им разные значения и выведите все три на экран.
            const uint score = 123;
            bool Score = true;
            var SCORE = "eeeee";
            Console.WriteLine($"score: {score}");
            Console.WriteLine($"Score: {Score}");
            Console.WriteLine($"SCORE: {SCORE}");

            //            Объявите переменные:
            //name типа string со значением "Бакштай Виталий",
            //age типа int со значением 25,
            //isStudent типа bool со значением true.
            //Выведите их значения на консоль.(Console.WriteLine)
            string name = "Бакштай Виталий";
            int age = 25;
            bool isStudent = true;
            Console.WriteLine(name + " " + age + " " + isStudent);

            //            Выведите на экран строку:
            //Он сказал: "Привет\n\tМир!"
            //так, чтобы она отобразилась именно с новой строки и табуляцией.
            Console.WriteLine("Он сказал: \"Привет\n\tМир!\"");

            //Объявите переменные всех целочисленных типов(byte, sbyte, short, ushort, int, uint, long, ulong)
            //и присвойте им максимальные допустимые значения. Выведите их.
            byte b = 255;
            sbyte sb = 127;
            short s = 32767;
            ushort us = 65535;
            int i = 2147483647;
            uint ui = 4294967295;
            long l = 9223372036854775807;
            ulong ul = 18446744073709551615;

            Console.WriteLine($" {b} - {sb} - {s} - {us} - {i} - {ui} - {l} - {ul}");

            //   Используя var, создайте переменные для хранения:
            //      строки "C#"
            //      целого числа 2026
            //      символа '!'
            var str = "C#";
            var num = 2026;
            var ch = '!';

            //            Запросите у пользователя(Console.ReadLine):
            //      целое число(возраст),
            //      вещественное число(вес),
            //      десятичное число(зарплата).
            //      Преобразуйте ввод с помощью Convert и выведите результат.
            Console.WriteLine("Введите возраст: ");
            sbyte userAge = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите свой вес: ");
            double userWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свою зп: ");
            uint userSalary = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"{userAge} {userWeight} {userSalary}");

            //            Присвойте int a = 300; и попробуйте преобразовать его в byte двумя способами:
            //            без checked(выведите результат),
            //с checked(обработайте исключение OverflowException).

            int a = 300;
            byte noChecked = (byte)a;
            Console.WriteLine($"Без checked: {noChecked}");

            try
            {
                byte yesChecked = checked((byte)a);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение!");
            }


            //            8.Упаковка и распаковка(boxing/ unboxing)
            //Упакуйте целое число 42 в переменную типа object, затем распакуйте обратно в int и выведите результат.

            int num42 = 42;
            object obj = num42;

            int newNum42 = checked((int)obj);

            //            9.Преобразование через Parse !!
            //Напишите программу, которая пытается преобразовать строку "123" в int с помощью int.Parse().

            string str123 = "123";
            int newStr123 = int.Parse(str123);

            //Создайте переменную object obj = "Hello";.
            //Проверьте с помощью is, является ли она строкой, и если да — выведите её.
            //Попробуйте преобразовать с помощью as и выведите результат, если не null.

            object objStr = "Hello";

            if (objStr is string sRes)
            {
                Console.WriteLine($"is: {sRes}");
            }

            string result = objStr as string;
            if (result != null)
            {
                Console.WriteLine($"as: {result}");
            }

            //Напишите программу, которая запрашивает два числа и выводит, какое из них больше, или сообщает, что они равны.

            Console.Write("Введите первое число: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int second = int.Parse(Console.ReadLine());

            if (first > second)
                Console.WriteLine("Первое число больше второго");
            else if (second > first)
                Console.WriteLine("Второе число больше первого");
            else
                Console.WriteLine("Числа равны");


            //Напишите программу, которая определяет, является ли число положительным:
            //            если да — выводит "Положительное", иначе — "Не положительное", используя тернарный оператор.

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            string message = number > 0 ? "Положительное" : "Не положительное";
            Console.WriteLine(message);


            //Напишите программу, которая запрашивает оценку(1–5) и выводит:
            //5 → «Отлично»
            //4 → «Хорошо»
            //3 → «Удовлетворительно»
            //2 или 1 → «Неудовлетворительно»
            //иное → «Неверная оценка»

            Console.Write("Введите оценку (1-5): ");
            string inputScore = Console.ReadLine();

            switch (inputScore)
            {
                case "5": Console.WriteLine("Отлично"); break;
                case "4": Console.WriteLine("Хорошо"); break;
                case "3": Console.WriteLine("Удовлетворительно"); break;
                case "2":
                case "1": Console.WriteLine("Неудовлетворительно"); break;
                default: Console.WriteLine("Неверная оценка"); break;
            }

            //Напишите программу, которая вычисляет сумму всех нечётных чисел от 1 до 99 с помощью цикла for.

            int sum = 0;
            for (int tmpI = 1; tmpI <= 99; tmpI += 2)
            {
                    sum += tmpI;
            }
            Console.WriteLine(sum);

            //Объявите массив double из 5 элементов, инициализируйте его любыми значениями.
            //Выведите длину массива и его третий элемент.

            double[] numbers = { 1.56745646, 2.23535634, 3.214325232543, 4.09876, 5.325423424 };

            Console.WriteLine($"Длина массива: {numbers.Length}");
            Console.WriteLine($"Третий элемент: {numbers[2]}");

            //Создайте массив строк: { "apple", "BANANA", "Cherry"}.
            //С помощью foreach выведите каждую строку в нижнем регистре.

            string[] fruits = { "apple", "BANANA", "Cherry" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit.ToLower());
            }

        }
    }
}