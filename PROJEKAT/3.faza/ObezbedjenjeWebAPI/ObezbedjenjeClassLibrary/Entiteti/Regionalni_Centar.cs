using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Regionalni_Centar
    {
        public virtual int ID { get; protected set; }
        public virtual string Adresa {get;set;}
        
        //ne stavljamo vezu ka Menadzeru zato sto postoji veza
        //od strane Menadzera ka Regionalnom Centru
        //a to je veza 1:1 pa smo pokrili tu vezu
        //Menadzer ZADUZEN za Regionalni Centar
        public virtual IList<Telefon_RC> Telefoni_RC { get; set; }
        public virtual IList<Grad> Obuhvata_Gradove { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public Regionalni_Centar() 
        {
            Telefoni_RC = new List<Telefon_RC>();
            Obuhvata_Gradove = new List<Grad>();
            Vozila = new List<Vozilo>();
        }
    }
}
