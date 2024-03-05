using System;
using System.Collections.Generic;
using System.Text;

namespace ObezbedjenjeClassLibrary.Entiteti
{
    public class Obilazi
    {
        public virtual int ID { get; protected set; }
        public virtual Objekat Objekat { get; set; }
        public virtual Smena Smena { get; set; }
    }
}
