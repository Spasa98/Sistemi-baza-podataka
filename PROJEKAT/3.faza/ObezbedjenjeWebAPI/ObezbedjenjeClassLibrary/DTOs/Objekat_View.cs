using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Objekat_View
    {
		public int ID { get; set; }
		public string Adresa { get; set; }
		public string Tip { get; set; }
		public int Povrsina { get; set; }

		//sve je obuhvaceno kroz veze Obilazi i Zaduzena
		//i kao referenca u Intervenciji
		//public IList<Intervencija_View> Intervencije { get; set; } //M:N
		//public IList<Smena_View> ObjekatObilaziSmena { get; set; } //M:N medjuveza objekta i smene
		//public IList<Ekipa_View> ZaObjekatZaduzenaEkipa { get; set; } //isto kao gore M:N medju veza objekta i ekipe
		public IList<Telefon_O_View> Telefoni_Objekta { get; set; }

		public Alarmni_Sistem_View Alarmni_Sistem { get; set; } //1:1

		public Objekat_View()
		{
			//Intervencije = new List<Intervencija_View>();
			//ObjekatObilaziSmena = new List<Smena_View>();
			//ZaObjekatZaduzenaEkipa = new List<Ekipa_View>();
			Telefoni_Objekta = new List<Telefon_O_View>();
		}

		public Objekat_View(Objekat o)
        {
			ID = o.ID;
			Adresa = o.Adresa;
			Tip = o.Tip;
			Povrsina = o.Povrsina;
			
			Alarmni_Sistem = new Alarmni_Sistem_View(o.Alarmni_Sistem);
			Telefoni_Objekta = new List<Telefon_O_View>();
			
			foreach(Telefon_O telefon in o.Telefoni_Objekta)
            {
				Telefoni_Objekta.Add(new Telefon_O_View(telefon));
            }
        }
	}
}
