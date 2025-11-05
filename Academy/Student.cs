using Academy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY
{
    internal class Student : Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }

        public Student(string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance)
            : base(lastName, firstName, age)
        {
            Init(speciality, group, rating, attendance);
            Console.WriteLine($"SConstructor: {GetHashCode()}");
        }
        public Student(Human human, string speciality, string group,
            double rating, double attendance) 
            : base(human)
        {
            Init(speciality, group, rating, attendance);
            Console.WriteLine($"SConstructor:\t {GetHashCode()}");
        }
        public Student( Student other): base(other)
        {
            Init(other.Speciality, other.Group, other.Rating, other.Attendance);
            Console.WriteLine($"SConstructor:\t {GetHashCode()}");
        }
        ~Student()
        {
            Console.WriteLine($"Destructor: \t {GetHashCode()}");
        }

        void Init(string speciality, string group, double rating, double attendance)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
        }

        public override string ToString()
        {
          return base.ToString()+$"{Speciality.PadRight(10)} {Group.PadRight(10)} " +
                $" {Rating.ToString().PadRight(10)} {Attendance.ToString().PadRight(10)}";          
        }

        public override string ToStringCSV()
        {
            return base.ToStringCSV() + $"{Speciality},{Group},{Rating},{Attendance}";
        }
    }
}
