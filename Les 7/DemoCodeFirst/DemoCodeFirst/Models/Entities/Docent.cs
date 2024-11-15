using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.Entities
{
    [Table("tblDocenten")]
    public class Docent:Persoon
    {
        public string Specialiteit { get; set; }

        public Docent(string specialiteit, string naam, DateTime geboortedatum): base(naam,geboortedatum)
        {
            Specialiteit = specialiteit;
        }

        public Docent()
        {
            
        }
    }
}
