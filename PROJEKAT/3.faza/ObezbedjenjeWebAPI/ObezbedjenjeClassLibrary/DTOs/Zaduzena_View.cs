using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Zaduzena_View
    {
        public int ID { get; set; }
        public Ekipa_View Ekipa { get; set; }
        public Objekat_View Objekat { get; set; }

        public Zaduzena_View()
        {

        }

        public Zaduzena_View(Zaduzena zad)
        {
            ID = zad.ID;
            Ekipa = new Ekipa_View(zad.Ekipa);
            Objekat = new Objekat_View(zad.Objekat);
        }
    }
}
