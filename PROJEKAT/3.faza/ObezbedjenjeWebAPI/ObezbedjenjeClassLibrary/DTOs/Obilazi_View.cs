using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Obilazi_View
    {
        public int ID { get; set; }
        public Objekat_View Objekat { get; set; }
        public Smena_View Smena { get; set; }

        public Obilazi_View()
        {

        }

        public Obilazi_View(Obilazi o)
        {
            ID = o.ID;
            Objekat = new Objekat_View(o.Objekat);
            Smena = new Smena_View(o.Smena);
        }
    }
}
