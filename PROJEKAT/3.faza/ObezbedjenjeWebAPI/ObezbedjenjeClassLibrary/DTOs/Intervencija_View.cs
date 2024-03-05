using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Intervencija_View
    {
		public int ID { get; set; }
		public DateTime Datum { get; set; }
		public string Vreme { get; set; }
		public string Opis { get; set; }

		public Ekipa_View Ekipa { get; set; }
		public Objekat_View Objekat { get; set; }

		public Intervencija_View()
        {

        }

		public Intervencija_View(Intervencija i)
        {
			ID = i.ID;
			Datum = i.Datum;
			Vreme = i.Vreme;
			Opis = i.Opis;
			Ekipa = new Ekipa_View(i.Ekipa);
			Objekat = new Objekat_View(i.Objekat);
        }
	}
}
