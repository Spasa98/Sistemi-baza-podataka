using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Grad
    {
        public virtual int ID { get; protected set; }
        public virtual string Naziv { get; set; }

        public virtual Menadzer Menadzer { get; set; }
        public virtual Regionalni_Centar Regionalni_Centar { get; set; }
    }
}
