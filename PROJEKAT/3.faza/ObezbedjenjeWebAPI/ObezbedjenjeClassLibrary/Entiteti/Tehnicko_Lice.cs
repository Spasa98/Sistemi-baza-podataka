using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    //strategija TablePerClassInheritance
    public class Tehnicko_Lice : Zaposleni
    {
        public virtual string Oblast_Tehnike { get; set; }
        public virtual string Strucna_Sprema { get; set; }

        public virtual IList<Odrzava> Lista_Odrzavanja { get; set; } //N:M

        public Tehnicko_Lice() 
        {
            Lista_Odrzavanja = new List<Odrzava>();
        }
    }
}
