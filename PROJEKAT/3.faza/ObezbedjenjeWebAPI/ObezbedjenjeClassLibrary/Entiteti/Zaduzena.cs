using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Zaduzena
    {
        public virtual int ID { get; protected set; }
        public virtual Ekipa Ekipa { get; set; }
        public virtual Objekat Objekat { get; set; }
    }
}
