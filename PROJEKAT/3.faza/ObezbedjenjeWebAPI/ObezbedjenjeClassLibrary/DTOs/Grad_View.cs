using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Grad_View
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        //ovo je obuhvaceno u Menadzeru i Regionalnom Centru
        //public Menadzer Menadzer { get; set; }
        //public Regionalni_Centar Regionalni_Centar { get; set; }

        public Grad_View()
        {

        }

        public Grad_View(Grad g)
        {
            ID = g.ID;
            Naziv = g.Naziv;
            
            //Menadzer = new Menadzer_View(g.Menadzer);
            //Regionalni_Centar = new Regionalni_Centar_View(g.Regionalni_Centar);
        }
    }
}
