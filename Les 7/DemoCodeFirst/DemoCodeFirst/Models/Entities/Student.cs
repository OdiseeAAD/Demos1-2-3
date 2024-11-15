using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.Entities
{
    [Table("tblStudenten")]
    public class Student: Persoon
    {
        public string Opleiding { get; set; }
        public List<Vak> Vakken { get; set; } = new List<Vak>();

        public Student(string opleiding, string naam, DateTime geboortedatum):base(naam, geboortedatum)
        {
            Opleiding = opleiding;
        }

        public Student()
        {
            
        }
    }
}
