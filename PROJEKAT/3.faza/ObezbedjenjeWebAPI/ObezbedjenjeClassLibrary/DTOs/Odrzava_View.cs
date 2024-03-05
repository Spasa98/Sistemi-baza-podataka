using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Odrzava_View
    {
        public int ID { get; set; }
        public DateTime Datum_Od { get; set; }
        public DateTime? Datum_Do { get; set; }

        public Tehnicko_Lice_View Tehnicko_Lice { get; set; }
        public Alarmni_Sistem_View Alarmni_Sistem { get; set; }
    
        public Odrzava_View()
        {

        }

        public Odrzava_View(Odrzava o)
        {
            ID = o.ID;
            Datum_Od = o.Datum_Od;
            Datum_Do = o.Datum_Do;

            /*
            this.Alarmni_Sistem = new Alarmni_Sistem_View(o.Alarmni_Sistem);
            this.Tehnicko_Lice = new Tehnicko_Lice_View(o.Tehnicko_Lice);
            */

            //imacemo vezu ka odrzavanju iz alarmnog sistema i tehnickog lica

            /* serijalizacija (circular reference)
             * za svako tehnicko lice/alarmni sistem koji se pribavlja
             * pribavljaju se i odrzavanja, koja opet imaju referencu na tehnicka lica/alarmni sistem
             * na taj nacin se samo vrtimo u krug sa podacima
             */
        }
    }
}
