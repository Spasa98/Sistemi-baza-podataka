using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
	public class Smena
	{
		public virtual int ID { get; protected set; }
		public virtual string Vreme_Pocetka { get; set; }
		public virtual string Vreme_Kraja { get; set; }

		public virtual IList<Ekipa> SmenuRadiEkipa { get; set; } //M:N
		public virtual IList<Objekat> SmenaObilaziObjekat  { get; set; } //M:N

		public Smena()
		{
			SmenuRadiEkipa = new List<Ekipa>();
			SmenaObilaziObjekat = new List<Objekat>();
		}
    }
}
