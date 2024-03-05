using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Intervencija_Mapiranja : ClassMap<Intervencija>
    {
        public Intervencija_Mapiranja()
        {
            //TABELA
            Table("INTERVENCIJA");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.INTERVENCIJA_ID");

            //VEZE
            //N:M
            References(x => x.Ekipa).Column("ID_EKIPA");
            //N:M
            References(x => x.Objekat).Column("ID_OBJEKAT");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Datum).Column("DATUM");
            Map(x => x.Vreme).Column("VREME");
            Map(x => x.Opis).Column("OPIS");
            }
    }
}
