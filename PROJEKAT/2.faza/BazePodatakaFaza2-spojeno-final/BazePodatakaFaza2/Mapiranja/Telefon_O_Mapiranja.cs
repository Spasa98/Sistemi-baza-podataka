using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Telefon_O_Mapiranja : ClassMap<Telefon_O>
    {
        public Telefon_O_Mapiranja()
        {
            //TABELA
            Table("TELEFON_O");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.TELEFON_O_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Telefon).Column("TELEFON");

            //VEZE
            //N:1
            References(x => x.Objekat).Column("ID_OBJEKAT").Cascade.All();
        }
    }
}
