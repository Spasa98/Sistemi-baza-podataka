using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Fizicko_Obezbedjenje_View : Zaposleni_View
    {
        public string Borilacka_Vestina { get; set; }
        public bool Vodja_Flag { get; set; }

        public Ekipa_View Ekipa { get; set; } //N:1

        public Fizicko_Obezbedjenje_View()
        {
            
        }

        public Fizicko_Obezbedjenje_View(Fizicko_Obezbedjenje fo) : base(fo)
        {
            Borilacka_Vestina = fo.Borilacka_Vestina;
            Vodja_Flag = fo.Vodja_Flag;
            Ekipa = new Ekipa_View(fo.Ekipa);
        }
    }
}
