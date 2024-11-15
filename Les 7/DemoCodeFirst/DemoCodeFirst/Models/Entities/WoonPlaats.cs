using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.Entities
{
    public class WoonPlaats
    {
        public WoonPlaats(string plaatsnaam)
        {
            PlaatsNaam = plaatsnaam;
        }

        public WoonPlaats()
        {
            
        }

        public int Id { get; set; }

        public string PlaatsNaam { get; set; }
    }
}
