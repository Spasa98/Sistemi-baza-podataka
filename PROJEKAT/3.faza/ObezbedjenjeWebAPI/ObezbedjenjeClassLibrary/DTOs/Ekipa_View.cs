using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Ekipa_View
    {
		public int ID { get; set; }
		public string Naziv { get; set; }

		//sve je obuhvaceno kroz veze Duzi, Radi, Zaduzena
		//i kroz reference u Fizicko Obezbedjenje i Intervencija
		//public IList<Fizicko_Obezbedjenje> FizickaObezbedjenja { get; set; }
		//public IList<Intervencija> Intervencije { get; set; }
		//public IList<Duzi> EkipaDuziVozila { get; set; }
		//public IList<Smena> EkipaRadiUSmeni { get; set; }
		//public IList<Objekat> EkipaZaduzenaZaObjekat { get; set; }

		public Ekipa_View()
		{
			//FizickaObezbedjenja = new List<Fizicko_Obezbedjenje_View>();
			//Intervencije = new List<Intervencija_View>();
			//EkipaDuziVozila = new List<Duzi_View>();
			//EkipaRadiUSmeni = new List<Smena_View>();
			//EkipaZaduzenaZaObjekat = new List<Objekat_View>();
		}

		public Ekipa_View(Ekipa e)
        {
			ID = e.ID;
			Naziv = e.Naziv;
        }
	}
}
