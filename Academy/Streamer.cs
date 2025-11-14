using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Academy
{
    internal class Streamer
    {
        void SetDirectory()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            string location = System.Windows.Forms.Application.ExecutablePath;
            Directory.SetCurrentDirectory($"{location}\\..\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
        }

        static readonly string delimiter = "_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n";

        public void Print(Human[] group)
        {
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
                Console.WriteLine(delimiter);
            }
            Console.WriteLine();
        }

        public void Save(Human[] group, string filename)
        {
            SetDirectory();
            StreamWriter writer = new StreamWriter(filename);

            for (int i = 0; i < group.Length; i++)
            {
                writer.WriteLine(group[i].ToStringCSV());

            }
            writer.Close();
            System.Diagnostics.Process.Start("notepad", filename);
        }

        public Human[] Load(string filename)
        {
            SetDirectory();
            List<Human> group = new List<Human>();
            StreamReader reader = new StreamReader(filename);

            try
            {
                while (!reader.EndOfStream)
                {
                    string buffer = reader.ReadLine();
                    string[] values = buffer.Split(',');
                    //Human human = humanFactory(values.First());
                    //human.Init(values); 
                    //group.Add(human);
                    group.Add(HumanFactory.Create(values[0]).Init(values));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            return group.ToArray();
        }
    }
}
