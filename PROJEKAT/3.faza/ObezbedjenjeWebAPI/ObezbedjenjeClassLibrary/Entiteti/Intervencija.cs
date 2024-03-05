using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Intervencija
    {
		public virtual int ID { get; protected set; }
		public virtual DateTime Datum { get; set; }
		public virtual string Vreme { get; set; }
		public virtual string Opis { get; set; }

		public virtual Ekipa Ekipa { get; set; }
		public virtual Objekat Objekat { get; set; }
	}
}
