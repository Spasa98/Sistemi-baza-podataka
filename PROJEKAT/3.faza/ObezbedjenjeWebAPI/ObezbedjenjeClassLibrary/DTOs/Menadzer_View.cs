using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.DTOs
{
    public class Menadzer_View : Zaposleni_View
    {
        public Regionalni_Centar_View Regionalni_Centar { get; set; } //1:1
        public IList<Grad_View> Pokriva_Gradove { get; set; } //1:N

        public Menadzer_View()
        {
            Pokriva_Gradove = new List<Grad_View>();
        }

        public Menadzer_View(Menadzer m) : base(m)
        {
            Regionalni_Centar = new Regionalni_Centar_View(m.Regionalni_Centar);
            Pokriva_Gradove = new List<Grad_View>();

            foreach(Grad g in m.Pokriva_Gradove)
            {
                Pokriva_Gradove.Add(new Grad_View(g));
            }
        }
    }
}
