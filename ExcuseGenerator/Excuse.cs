using System;
using System.IO;

// Cada desculpa é salva num arquivo de texto separado.
// A primeira linha do arquivo é uma desculpa, a segunda
// é o resultado e a terceira é a dta quando foi usada
// pela última vez (use o método ToString() de DateTimePicker()

namespace ExcuseManager
{
    public class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse(Random random)
        {
            // Olha na pasta de desculpas, escolhe uma delas aleatoriamente
            // e a abre.
        }

        public Excuse(string description)
        {
            Description = description;
        }

        public Excuse(string description, DateTime lastUsed, string excusePath) : this(description)
        {
            LastUsed = lastUsed;
            ExcusePath = excusePath;
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