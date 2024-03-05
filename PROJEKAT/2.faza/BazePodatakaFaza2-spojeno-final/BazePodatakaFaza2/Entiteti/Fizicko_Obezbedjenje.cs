using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
    //strategija TablePerClassInheritance
    public class Fizicko_Obezbedjenje : Zaposleni
    {
        public virtual string Borilacka_Vestina { get; set; }
        public virtual bool Vodja_Flag { get; set; }

        public virtual Ekipa Ekipa { get; set; } //N:1
    }
}
