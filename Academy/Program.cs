//#define INHERITANCE_1
//#define INHERITANCE_2
//#define WRITE_TO_FILE

using Academy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ACADEMY
{
    internal class Program
    {
        static readonly string delimiter = "_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n";


        static void Main(string[] args)
        {
#if INHERITANCE_1
            Human human = new Human("Montana", "Antonio", 25);
            human.Info();

            Console.WriteLine(delimiter);

            Student student = new Student("Pinkman","Jesse", 22, "Chemistry", "WW_220",90,95);
            student.Info();
            Console.WriteLine(delimiter);


            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            teacher.Info();
            Console.WriteLine(delimiter);
#endif
#if INHERITANCE_2

            Human human = new Human("Pinkman", "Jesse", 22);
            human.Info();
            Console.WriteLine(delimiter);


            Student student = new Student(human, "Chemistry", "ww_220", 90, 95);
            student.Info();
            Console.WriteLine(delimiter);

            Teacher teacheer = new Teacher(new Human("White", "Waiter", 50), "Chemistry", 25);
            teacheer.Info();
            Console.WriteLine(delimiter);

            Human h_hank = new Human("Schreder", "Hank", 40);
            Student s_hank = new Student(h_hank, "Criminalistics", "OBN", 50, 60);
            Graduate graduate = new Graduate(s_hank, "How to catch Heisenberg");
            graduate.Info();
            Console.WriteLine(delimiter);

#endif
            Streamer streamer = new Streamer();
            //Base-class pointers: Generalisation
            //(Upcast - приведение дочернего объекта к базовуму типу)
#if WRITE_TO_FILE

            Human[] group =
            {
                new Student ("Pinkman", "Jesse", 22, "Chemistry", "ww_220", 90, 95),
                new Teacher ("White", "Waiter", 50,"Chemistry", 25),
                new Graduate ("Schreder", "Hank", 40, "Criminalistics", "OBN", 50, 60, "How to catch Heisenberg"),
                new Student ("Vercetty", "Tommy", 30,"Theft", "Vice", 98, 99),
                new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
            };
            Console.WriteLine(delimiter);

            //Specialisation: виртуальный метод  virtual - override

            for (int i = 0; i < group.Length; i++)
            {
                //group[i].Info();
                Console.WriteLine(group[i].ToString());
                Console.WriteLine(delimiter);
            }
            streamer.Save(group, "group.txt");

            string Path = "group_members.txt";
            File.Create(Path).Close();

            using (StreamWriter sw = new StreamWriter(Path))
            {
                for (int i = 0; i < group.Length; i++)
                {
                    sw.WriteLine(group[i]);
                    sw.WriteLine(delimiter);
                }
            }

            using (StreamReader sr = new StreamReader(Path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Process.Start("notepad", "group_members.txt");

            //Save(group, Path);

            //------------------------                   
#endif

            Human[] group = streamer.Load("group.txt");
            streamer.Print(group);

        }
    }
}
