namespace MyApp
{

    internal class homeWork2
    {
        static void Main(string[] args)
        {
            // Подсчёт гласных
            // Напишите метод CountVowels(string text),
            // который возвращает количество гласных букв(а, е, ё, и, о, у, ы, э, ю, я) в строке без учёта регистра.

            static int CountVowels(string text)
            {
                var vowels = "аеёиоуыэюя";
                var count = 0;
                foreach (var item in text)
                {
                    if (vowels.Contains(char.ToLower(item)))
                    {
                        count++;
                    }
                }
                return count;
            }

            var myText1 = "Всем привет.";
            Console.WriteLine(CountVowels(myText1));

            // Переворот слов(!!)
            // Напишите метод ReverseWords(string text), который переворачивает порядок слов в строке.
            // Пример: "Я изучаю Шарпы" → "Шарпы изучаю Я"

            static string ReverseWords(string text)
            {
                var newString = "";
                var words = text.Split(new[] { ' ' });
                for (var i = words.Length - 1; i >= 0; i--)
                {
                    newString += words[i];
                    if (i != 0)
                    {
                        newString += " ";
                    }
                }
                return newString;
            }

            var myText2 = "Я изучаю Шарпы";

            Console.WriteLine(ReverseWords(myText2));

            // Валидация пароля(!!)
            // Напишите метод boolean IsValidPassword(string password), проверяющий, что пароль:
            // длиной ≥ 8 символов
            // содержит хотя бы одну цифру
            // содержит хотя бы одну заглавную букву

            bool IsValidPassword(string password)
            {
                if (password.Length < 8) { return false; }
                else
                {
                    var hasDigit = false;
                    var hasUpperLetter = false;
                    foreach (char c in password)
                    {
                        if (char.IsDigit(c))
                        {
                            hasDigit = true;
                        }
                        if (char.IsUpper(c))
                        {
                            hasUpperLetter = true;
                        }
                        if (hasDigit && hasUpperLetter)
                        {
                            break;
                        }

                    }
                    return hasDigit && hasUpperLetter;
                }
            }
            var myPassword = "34566Bgg";

            Console.WriteLine(IsValidPassword(myPassword));


            // Метод string Greet(string name, int hour) возвращает приветствие в зависимости от времени суток:
            // 0–5 - «Доброй ночи», 6–11 - «Доброе утро», 12–17 - «Добрый день», 18–23 - «Добрый вечер».

            static string Greet(string name, int hour)
            {
                switch (hour)
                {
                    case var n when n >= 0 && n <= 5:
                        return "Доброй ночи";
                    case var n when n >= 6 && n <= 11:
                        return "Доброе утро";
                    case var n when n >= 12 && n <= 17:
                        return "Добрый день";
                    case var n when n >= 18 && n <= 23:
                        return "Добрый вечер";
                }
                return "Привет";
            }
        }

        // Реализуйте перегруженные методы Multiply:
        // int Multiply(int a, int b)
        // double Multiply(double a, double b)
        // int Multiply(int a, int b, int c) — произведение трёх чисел

        public int Multiply(int a, int b) {
            return a * b;
        }

        public double Multiply(double a, double b) {
            return a * b;
        } 

        public int Multiply(int a, int b, int c) {
            return a * b * c;
        }


    }
    public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    public enum Grade { F = 1, D = 2, C = 3, B = 4, A = 5 };

    public enum Direction { North, South, East, West };

    public static class EnumExtensions
    {
        // Создайте enum Day { MONDAY, TUESDAY, ..., SUNDAY }
        // с методом IsWeekend(), возвращающим true для субботы и воскресенья.
        public static bool IsWeekend(this Day day)
        {
            return day is Day.Saturday or Day.Sunday;
        }


        // Создайте enum Grade { A(5), B(4), C(3), D(2), F(1) } с полем int numericValue.
        // Реализуйте метод IsPassed(), возвращающий true, если оценка ≥ 3.
        public static bool IsPassed(this Grade grade)
        {
            return (int)grade >= 3;
        }

        // enum Direction { NORTH, SOUTH, EAST, WEST } с методом Direction Opposite(), возвращающим противоположное направление.
        public static Direction Opposite(this Direction direction)
        {
            switch (direction)
            {
                case Direction.North: return Direction.South;
                case Direction.South: return Direction.North;
                case Direction.West: return Direction.East;
                case Direction.East: return Direction.West;
                default: return direction;
            }
        }
    }

}

