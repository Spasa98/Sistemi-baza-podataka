using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Tehnicko_Lice_View : Zaposleni_View
    {
        public string Oblast_Tehnike { get; set; }
        public string Strucna_Sprema { get; set; }

        public IList<Odrzava_View> Lista_Odrzavanja { get; set; } //N:M

        public Tehnicko_Lice_View()
        {
            Lista_Odrzavanja = new List<Odrzava_View>();
        }

        public Tehnicko_Lice_View(Tehnicko_Lice tl) : base(tl)
        {
            Oblast_Tehnike = tl.Oblast_Tehnike;
            Strucna_Sprema = tl.Strucna_Sprema;

            Lista_Odrzavanja = new List<Odrzava_View>();

            foreach(Odrzava odrzava in tl.Lista_Odrzavanja)
            {
                Lista_Odrzavanja.Add(new Odrzava_View(odrzava));
            }
        }
    }
}
