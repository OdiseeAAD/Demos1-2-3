using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Models.Entities
{
    // Tabel
    [Table("tblPersonen")]
    public class Persoon
    {
        // Kolommen
        [Key]
        public int Id { get; set; }

        [Column("naam")]
        [MaxLength(50)]
        public String Naam { get; set; }

        [Column("geboortedatum",TypeName="datetime2")]
        public  DateTime? Geboortedatum { get; set; }

        public WoonPlaats? WoonPlaats { get; set; }

        public Persoon(string naam, DateTime geboortedatum)
        {
            Naam = naam;
            Geboortedatum = geboortedatum;
        }
        public Persoon()
        {

        }
    }
}
