using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Radi_Mapiranja : ClassMap<Radi>
    {
        public Radi_Mapiranja()
        {
            //TABELA
            Table("RADI");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.GRAD_ID");

            //VEZE
            References(x => x.Ekipa).Column("ID_EKIPA");
            References(x => x.Smena).Column("ID_SMENA");
        }
    }
}
