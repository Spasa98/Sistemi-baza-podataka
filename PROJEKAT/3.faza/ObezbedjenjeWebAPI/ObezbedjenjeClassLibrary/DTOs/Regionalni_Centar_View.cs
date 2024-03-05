using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Regionalni_Centar_View
    {
        public int ID { get; set; }
        public string Adresa { get; set; }
        
        public IList<Telefon_RC_View> Telefoni_RC { get; set; }
        public IList<Grad_View> Obuhvata_Gradove { get; set; }
        
        //public IList<Vozilo_View> Vozila { get; set; }

        public Regionalni_Centar_View()
        {
            Telefoni_RC = new List<Telefon_RC_View>();
            Obuhvata_Gradove = new List<Grad_View>();
            //Vozila = new List<Vozilo_View>();
        }

        public Regionalni_Centar_View(Regionalni_Centar rc)
        {
            ID = rc.ID;
            Adresa = rc.Adresa;

            Telefoni_RC = new List<Telefon_RC_View>();
            Obuhvata_Gradove = new List<Grad_View>();
            //Vozila = new List<Vozilo_View>();

            foreach (Telefon_RC telefon in rc.Telefoni_RC)
            {
                Telefoni_RC.Add(new Telefon_RC_View(telefon));
            }

            foreach (Grad grad in rc.Obuhvata_Gradove)
            {
                Obuhvata_Gradove.Add(new Grad_View(grad));
            }

            /*foreach (Vozilo vozilo in rc.Vozila)
            {
                Vozila.Add(new Vozilo_View(vozilo));
            }*/
        }
    }
}
