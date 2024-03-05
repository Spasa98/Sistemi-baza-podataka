using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Alarmni_Sistem_View
    {
		public int ID { get; set; }
		public string Proizvodjac { get; set; }
		public DateTime Datum_Instalacije { get; set; }
		public int Godina_Proizvodnje { get; set; }
		public bool DTO_Flag { get; set; }
		public int? Vertikalna_Rezolucija { get; set; }
		public int? Horizontalna_Rezolucija { get; set; }
		public bool US_Flag { get; set; }
		public string OpsegFrekfencije { get; set; }
		public bool DP_Flag { get; set; }
		public int? Osetljivost { get; set; }

		public IList<Odrzava_View> Odrzavanja { get; set; }

		public Alarmni_Sistem_View()
		{
			Odrzavanja = new List<Odrzava_View>();
		}

		public Alarmni_Sistem_View(Alarmni_Sistem als)
        {
			ID = als.ID;
			Proizvodjac = als.Proizvodjac;
			Datum_Instalacije = als.Datum_Instalacije;
			Godina_Proizvodnje = als.Godina_Proizvodnje;
			DTO_Flag = als.DTO_Flag;
			Vertikalna_Rezolucija = als.Vertikalna_Rezolucija;
			Horizontalna_Rezolucija = als.Horizontalna_Rezolucija;
			US_Flag = als.US_Flag;
			OpsegFrekfencije = als.OpsegFrekfencije;
			DP_Flag = als.DP_Flag;
			Osetljivost = als.Osetljivost;

			Odrzavanja = new List<Odrzava_View>();

			foreach(Odrzava odrzava in als.Odrzavanja)
            {
				Odrzavanja.Add(new Odrzava_View(odrzava));
            }
        }
	}
}
