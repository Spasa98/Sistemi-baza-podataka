using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Duzi_Mapiranja : ClassMap<Duzi>
    {
        public Duzi_Mapiranja()
        {
            //TABELA
            Table("DUZI");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.DUZI_ID");

            //VEZE
            //N:M
            References(x => x.Ekipa).Column("ID_EKIPA");
            //N:M
            References(x => x.Vozilo).Column("ID_VOZILO");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Duzi_Od).Column("DUZI_OD");
            Map(x => x.Duzi_Do).Column("DUZI_DO");
        }
    }
}
