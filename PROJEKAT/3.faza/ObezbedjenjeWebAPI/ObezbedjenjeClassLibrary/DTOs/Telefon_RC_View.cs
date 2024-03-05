using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Telefon_RC_View
    {
        public int ID { get; set; }
        public string Telefon { get; set; }

        //ovo je odradjeno u Regionalnom Centru
        //public Regionalni_Centar_View Regionalni_Centar { get; set; }

        public Telefon_RC_View()
        {

        }

        public Telefon_RC_View(Telefon_RC telRC)
        {
            ID = telRC.ID;
            Telefon = telRC.Telefon;
            //Regionalni_Centar = new Regionalni_Centar_View(telRC.Regionalni_Centar);
        }
    }
}
