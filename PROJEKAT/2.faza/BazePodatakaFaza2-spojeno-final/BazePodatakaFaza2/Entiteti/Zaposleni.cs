using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
    public class Zaposleni
    {
        public virtual int ID { get; protected set; }
        public virtual Int64 JMBG { get; set; } //int64 zato sto kod obicnog int-a staju 10 cifre
        public virtual string Ime { get; set; } //string jer se string poklapa sa varchar
        public virtual string Prezime { get; set; }
        public virtual DateTime Datum_Rodjenja { get; set; }
        public virtual char Pol { get; set; }
    }
}
