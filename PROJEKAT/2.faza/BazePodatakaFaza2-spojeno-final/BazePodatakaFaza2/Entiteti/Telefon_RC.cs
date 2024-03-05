using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
    public class Telefon_RC
    {
		public virtual int ID { get; protected set; }
		public virtual string Telefon { get; set; }
		public virtual Regionalni_Centar Regionalni_Centar { get; set; }
	}
}
