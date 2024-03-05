using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Grad_Mapiranja : ClassMap<Grad>
    {
        public Grad_Mapiranja()
        {
            //TABELA
            Table("GRAD");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.GRAD_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Naziv).Column("NAZIV");

            //VEZE
            //N:1
            References(x => x.Menadzer).Column("ID_MENADZER").LazyLoad();
            //N:1
            References(x => x.Regionalni_Centar).Column("ID_REGIONALNI_CENTAR").LazyLoad();
        }
    }
}
