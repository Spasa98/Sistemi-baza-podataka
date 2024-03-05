using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Obilazi_Mapiranja : ClassMap<Obilazi>
    {
        public Obilazi_Mapiranja()
        {
            //TABELA
            Table("OBILAZI");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.GRAD_ID");

            //VEZE
            References(x => x.Objekat).Column("ID_OBJEKAT");
            References(x => x.Smena).Column("ID_SMENA");
        }
    }
}
