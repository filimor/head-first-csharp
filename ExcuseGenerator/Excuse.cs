using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcuseManager
{
    [Serializable]
    public class Excuse : ISerializable
    {
        private BinaryFormatter _formatter;

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
            //string[] fileNames = Directory.GetFiles(path,"*.txt");
            string[] fileNames = Directory.GetFiles(path,"*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        internal Excuse(SerializationInfo info, StreamingContext context)
        {
            Description = info.GetString(nameof(Description));
            Results = info.GetString(nameof(Results));
            LastUsed = (DateTime)info.GetValue("LastUsed", typeof(DateTime));
        }

        public void OpenFile(string path)
        {
            //using (var sr = new StreamReader(path))
            //{
            //    Description = sr.ReadLine();
            //    Results = sr.ReadLine();
            //    LastUsed = Convert.ToDateTime(sr.ReadLine());
            //}
            _formatter = new BinaryFormatter();
            Excuse excuse;
            using (Stream input = File.OpenRead(path))
            {
                excuse = (Excuse)_formatter.Deserialize(input);
            }
            Description = excuse.Description;
            Results = excuse.Results;
            LastUsed = excuse.LastUsed;
        }

        public void Save(string path)
        {
            //using (var sw = new StreamWriter(path))
            //{
            //    sw.WriteLine(Description);
            //    sw.WriteLine(Results);
            //    sw.WriteLine(LastUsed);
            //}
            _formatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(path))
            {
                _formatter.Serialize(output, this);
            }
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Description", Description);
            info.AddValue("Results", Results);
            info.AddValue("LastUsed", LastUsed);
            info.AddValue("ExcusePath", ExcusePath);
        }
    }
}