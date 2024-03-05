using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Radi_View
    {
        public int ID { get; set; }
        public Ekipa_View Ekipa { get; set; }
        public Smena_View Smena { get; set; }

        public Radi_View()
        {

        }

        public Radi_View(Radi r)
        {
            ID = r.ID;
            Ekipa = new Ekipa_View(r.Ekipa);
            Smena = new Smena_View(r.Smena);
        }
    }
}
