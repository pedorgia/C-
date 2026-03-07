using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HomeWork12
{
    class Person(string name, int age, string email, bool isStudent)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Email { get; set; } = email;
        public bool IsStudent { get; set; } = isStudent;
    }

    class ReflectionTest
    {
        public static void PrintProperties(object obj)
        {
            if (obj == null) return;
            var type = obj.GetType();
            Console.WriteLine($"Тип объекта: {type.Name}");

            var properties = type.GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                var value = prop.GetValue(obj);
                Console.WriteLine($"{prop.Name}: {value}");
            }
        }
    }
}
