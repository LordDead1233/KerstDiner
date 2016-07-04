using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerstDinerFamilieJanssen
{
    public class Gerecht
    {
        public string Naam { get; set; }
        public string BereidVoor { get; set; }
        public string SoortEten { get; set; }

        public Gerecht(string naam, string bereidvoor, string soorteten)
        {
            this.Naam = naam;
            this.BereidVoor = bereidvoor;
            this.SoortEten = soorteten;
        }

        public override string ToString()
        {
            return Naam + " " + BereidVoor + " " + SoortEten;
        }
    }
}
