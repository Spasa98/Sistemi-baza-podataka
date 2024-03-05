using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Duzi
    {
		public virtual int ID { get; protected set; }
		public virtual DateTime Duzi_Od { get; set; }
		public virtual DateTime Duzi_Do { get; set; }

		public virtual Vozilo Vozilo { get; set; }
		public virtual Ekipa Ekipa { get; set; }
	}
}
