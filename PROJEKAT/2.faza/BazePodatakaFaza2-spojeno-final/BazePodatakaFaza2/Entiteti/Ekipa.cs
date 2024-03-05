using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
    public class Ekipa
    {
        public virtual int ID { get; protected set; }
        public virtual string Naziv { get; set; }

        public virtual IList<Fizicko_Obezbedjenje> FizickaObezbedjenja { get; set; }
        public virtual IList<Duzi> EkipaDuziVozila { get; set; }
		public virtual IList<Intervencija> Intervencije { get; set; }
		public virtual IList<Smena> EkipaRadiUSmeni { get; set; }
		public virtual IList<Objekat> EkipaZaduzenaZaObjekat { get; set; }

		public Ekipa()
		{
			FizickaObezbedjenja = new List<Fizicko_Obezbedjenje>();
			EkipaDuziVozila = new List<Duzi>();
			Intervencije = new List<Intervencija>();
			EkipaRadiUSmeni = new List<Smena>();
			EkipaZaduzenaZaObjekat= new List<Objekat>();
		}
    }
}
