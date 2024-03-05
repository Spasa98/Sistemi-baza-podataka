using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
    public class Alarmni_Sistem
    {
		public virtual int ID { get; protected set; }
		public virtual string Proizvodjac { get; set; }
		public virtual DateTime Datum_Instalacije { get; set; }
		public virtual int Godina_Proizvodnje { get; set; }
		public virtual bool DTO_Flag { get; set; }
		public virtual int? Vertikalna_Rezolucija { get; set; }
		public virtual int? Horizontalna_Rezolucija { get; set; }
		public virtual bool US_Flag { get; set; }
		public virtual string OpsegFrekfencije { get; set; }
		public virtual bool DP_Flag { get; set; }
		public virtual int? Osetljivost { get; set; }

		public virtual IList<Odrzava> Odrzavanja { get; set; }

		public Alarmni_Sistem()
		{
			Odrzavanja = new List<Odrzava>();
		}
	}
}
