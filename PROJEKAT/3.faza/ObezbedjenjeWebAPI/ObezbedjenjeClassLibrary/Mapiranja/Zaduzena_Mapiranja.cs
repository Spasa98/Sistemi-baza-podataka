using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Zaduzena_Mapiranja : ClassMap<Zaduzena>
    {
        public Zaduzena_Mapiranja()
        {
            //TABELA
            Table("ZADUZENA");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.GRAD_ID");

            //VEZE
            References(x => x.Ekipa).Column("ID_EKIPA");
            References(x => x.Objekat).Column("ID_OBJEKAT");
        }
    }
}
