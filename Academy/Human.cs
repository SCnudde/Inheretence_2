using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public Human(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t {GetHashCode()}");
        }

        public Human (Human other)// Конструктор копирования
        {
            LastName = other.LastName;
            FirstName = other.FirstName;
            Age = other.Age;
            Console.WriteLine($"CopyCOnstructor: \t {GetHashCode() }");
        }

        ~Human()
        {
            Console.WriteLine($"HDestructor:\t {GetHashCode()}");
        }

        public virtual void Info()
        {
            Console.WriteLine($"{LastName} {FirstName} {Age}");
        }

        public override string ToString()
        {
                return //Split ('.') разделяет "Academy.Type" по точке на массив строк, и из этого массива
                      //мы берем последний элемент
                $"{ base.ToString().Split('.').Last()}:".PadRight(10) +
                $" {LastName.PadRight(10)} {FirstName.PadRight(10)} {Age.ToString().PadRight(10)}";
        // PadRight() - выравнивает строку по левому борту. от Padding - выравнивание
        
        }

        public virtual string ToStringCSV()
        {
            return this.GetType().ToString().Split('.').Last() + "," + $"{LastName}, {FirstName}, {Age} ";
        }

    }
}
