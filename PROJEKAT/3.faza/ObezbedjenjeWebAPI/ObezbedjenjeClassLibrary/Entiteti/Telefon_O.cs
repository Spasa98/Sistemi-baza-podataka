using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Telefon_O
    {
		public virtual int ID { get; protected set; }
		public virtual string Telefon { get; set; }
		public virtual Objekat Objekat { get; set; }
	}
}
