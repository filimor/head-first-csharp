using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public void Save(string excuse)
        {
            
        }
    }
}
