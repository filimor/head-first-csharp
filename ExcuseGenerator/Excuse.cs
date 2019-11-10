using System;
using System.IO;

namespace ExcuseManager
{
    public class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = string.Empty;
        }

        public Excuse(string path)
        {
            ExcusePath = path;
        }

        public Excuse(Random random, string path)
        {
            string[] fileNames = Directory.GetFiles(path,"*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                Description = sr.ReadLine();
                Results = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
        }

        public void Save(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);
            }
        }
    }
}