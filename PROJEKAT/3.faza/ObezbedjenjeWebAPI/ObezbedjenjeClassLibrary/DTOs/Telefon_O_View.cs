using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Telefon_O_View
    {
        public int ID { get; set; }
        public string Telefon { get; set; }
        
        //ovo je odradjeno u Objektu
        //public Objekat_View Objekat { get; set; }

        public Telefon_O_View()
        {

        }

        public Telefon_O_View(Telefon_O telO)
        {
            ID = telO.ID;
            Telefon = telO.Telefon;

            //Objekat = new Objekat_View(telO.Objekat);
        }
    }
}
