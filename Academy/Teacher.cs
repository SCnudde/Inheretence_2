using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher : Human
    {
        public string Speciality { get; set; }
        public int Experience { get; set; }

        public Teacher(string lastName, string firstName,
            int age, string speciality, int experience)
            : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"TConstructor: \t{GetHashCode()}");
        }

        public Teacher(Human human, string speciality, int experience): base(human)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"HConstructor: \t{GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"HDestructor: \t{GetHashCode()}");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"{Speciality} {Experience}");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Speciality.PadRight(10)} {Experience.ToString().PadRight(10)} ";
        }

        public override string ToStringCSV()
        {
           return base.ToStringCSV() + $",{Speciality} {Experience}";
        }
    }
}
