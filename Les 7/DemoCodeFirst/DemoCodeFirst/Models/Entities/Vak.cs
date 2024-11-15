using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.Entities
{
    public class Vak
    {
        public int Id { get; set; }
        public string VakNaam { get; set; }
        public List<Student> Studenten { get; set; }
        public Vak(string vakNaam)
        {
            VakNaam = vakNaam;
        }

        public Vak()
        {
                
        }
    }
}
