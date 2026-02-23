using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }

    class Student
    {
        public int Grade { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Order
    {
        public int Id { get; set; }
        public List<int> Prices { get; set; }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }



}
