using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Odrzava_Mapiranja : ClassMap<Odrzava>
    {
        public Odrzava_Mapiranja()
        {
            //TABELA
            Table("ODRZAVA");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.ODRZAVA_ID");

            //VEZE
            //N:M
            References(x => x.Tehnicko_Lice).Column("ID_TEHNICKO_LICE").LazyLoad();
            //N:M
            References(x => x.Alarmni_Sistem).Column("ID_ALARMNI_SISTEM").LazyLoad();

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Datum_Od).Column("DATUM_OD");
            Map(x => x.Datum_Do).Column("DATUM_DO");
        }
    }
}
