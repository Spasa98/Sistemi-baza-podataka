using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Vozilo
    {
		public virtual int ID { get; protected set; }
		public virtual string Registarska_Oznaka { get; set; }
		public virtual string Model { get; set; }
		public virtual string Proizvodjac { get; set; }
		public virtual string Tip { get; set; }
		public virtual string Boja { get; set; }

		public virtual IList<Duzi> VoziloDuziEkipa { get; set; }
		public virtual Regionalni_Centar Regionalni_Centar { get; set; }

		public Vozilo()
		{
			VoziloDuziEkipa = new List<Duzi>();
		}
    }
}
