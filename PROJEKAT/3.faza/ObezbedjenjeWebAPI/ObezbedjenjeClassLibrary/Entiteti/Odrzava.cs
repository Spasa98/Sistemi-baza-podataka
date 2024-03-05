using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Odrzava
    {
		public virtual int ID { get; protected set; }
		public virtual DateTime Datum_Od { get; set; }
		public virtual DateTime? Datum_Do { get; set; }

		public virtual Tehnicko_Lice Tehnicko_Lice { get; set; }
		public virtual Alarmni_Sistem Alarmni_Sistem { get; set; }
    }
}
