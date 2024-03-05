using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazePodatakaFaza2.Entiteti
{
    //strategija TablePerClassInheritance
    public class Menadzer : Zaposleni
    {
        public virtual Regionalni_Centar Regionalni_Centar { get; set; } //1:1
        public virtual IList<Grad> Pokriva_Gradove { get; set; } //1:N

        public Menadzer() 
        {
            Pokriva_Gradove = new List<Grad>();
        }
    }
}
