using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Zaposleni_View
    {
        public int ID { get; set; }
        public Int64 JMBG { get; set; } //int64 zato sto kod obicnog int-a staju 10 cifre
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Datum_Rodjenja { get; set; }
        public char Pol { get; set; }

        public Zaposleni_View()
        {

        }

        public Zaposleni_View(Zaposleni zap)
        {
            ID = zap.ID;
            JMBG = zap.JMBG;
            Ime = zap.Ime;
            Prezime = zap.Prezime;
            Datum_Rodjenja = zap.Datum_Rodjenja;
            Pol = zap.Pol;
        }
    }
}
