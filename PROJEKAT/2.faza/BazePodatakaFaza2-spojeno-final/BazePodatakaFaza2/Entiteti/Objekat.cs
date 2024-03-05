using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
	public class Objekat
	{
		public virtual int ID { get; protected set; }
		public virtual string Adresa { get; set; }
		public virtual string Tip { get; set; }
		public virtual int Povrsina { get; set; }

		public virtual IList<Intervencija> Intervencije { get; set; } //M:N
		public virtual IList<Smena> ObjekatObilaziSmena { get; set; } //M:N medjuveza objekta i smene
		public virtual IList<Telefon_O> Telefoni_Objekta { get; set; }
		public virtual IList<Ekipa> ZaObjekatZaduzenaEkipa { get; set; } //isto kao gore M:N medju veza objekta i ekipe
		public virtual Alarmni_Sistem Alarmni_Sistem { get; set; }
		
		public Objekat()
		{
			Intervencije=new List <Intervencija>();
			ObjekatObilaziSmena = new List<Smena>();
			ZaObjekatZaduzenaEkipa = new List<Ekipa>();
			Telefoni_Objekta = new List<Telefon_O>();
		}
    }
}
