using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Duzi_View
    {
		public int ID { get; set; }
		public DateTime Duzi_Od { get; set; }
		public DateTime Duzi_Do { get; set; }

		public Vozilo_View Vozilo { get; set; }
		public Ekipa_View Ekipa { get; set; }

		public Duzi_View()
        {

        }

		public Duzi_View(Duzi duzi)
        {
			ID = duzi.ID;
			Duzi_Od = duzi.Duzi_Od;
			Duzi_Do = duzi.Duzi_Do;
			Vozilo = new Vozilo_View(duzi.Vozilo);
			Ekipa = new Ekipa_View(duzi.Ekipa);
        }
	}
}
