using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Smena_View
    {
		public int ID { get; set; }
		public string Vreme_Pocetka { get; set; }
		public string Vreme_Kraja { get; set; }

		//ovo je odradjeno kroz veze Radi i Obilazi
		//public IList<Ekipa_View> SmenuRadiEkipa { get; set; } //M:N
		//public IList<Objekat_VIew> SmenaObilaziObjekat { get; set; } //M:N

		public Smena_View()
		{
			//SmenuRadiEkipa = new List<Ekipa_View>();
			//SmenaObilaziObjekat = new List<Objekat_View>();
		}

		public Smena_View(Smena s)
        {
			ID = s.ID;
			Vreme_Pocetka = s.Vreme_Pocetka;
			Vreme_Kraja = s.Vreme_Kraja;

			/*
				SmenuRadiEkipa = new List<Ekipa_View>();
				SmenaObilaziObjekat = new List<Objekat_View>();
				foreach(Ekipa e in s.SmenuRadiEkipa)
				{
					SmenuRadiEkipa.Add(new Ekipa_View(e));

				}
				foreach (Objekat o in s.SmenaObilaziObjekat)
				{
					SmenaObilaziObjekat.Add(new Objekat_View(o));

				}
			*/
		}
	}
}
