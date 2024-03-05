using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Vozilo_View
    {
		public int ID { get; set; }
		public string Registarska_Oznaka { get; set; }
		public string Model { get; set; }
		public string Proizvodjac { get; set; }
		public string Tip { get; set; }
		public string Boja { get; set; }

		//ovo je odradjeno kroz vezu Duzi
		//public IList<Duzi_View> VoziloDuziEkipa { get; set; }
		public Regionalni_Centar_View Regionalni_Centar { get; set; } //N:1

		public Vozilo_View()
		{
			//VoziloDuziEkipa = new List<Duzi_View>();
		}

		public Vozilo_View(Vozilo v)
		{
			ID = v.ID;
			Registarska_Oznaka = v.Registarska_Oznaka;
			Model = v.Model;
			Proizvodjac = v.Proizvodjac;
			Tip = v.Tip;
			Boja = v.Boja;
			
			Regionalni_Centar = new Regionalni_Centar_View(v.Regionalni_Centar);

			/*
				VoziloDuziEkipa = new List<Duzi_View>();
				foreach (Ekipa e in v.VoziloDuziEkipa)
				{
					VoziloDuziEkipa.Add(new Ekipa_View(e));

				}
			*/
		}
	}
}
