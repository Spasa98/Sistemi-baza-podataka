using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Telefon_RC_Mapiranja : ClassMap<Telefon_RC>
    {
        public Telefon_RC_Mapiranja()
        {
            //TABELA
            Table("TELEFON_RC");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.TELEFON_RC_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Telefon).Column("TELEFON");

            //VEZE
            //N:1
            References(x => x.Regionalni_Centar).Column("ID_REGIONALNI_CENTAR").LazyLoad();
        }
    }
}
