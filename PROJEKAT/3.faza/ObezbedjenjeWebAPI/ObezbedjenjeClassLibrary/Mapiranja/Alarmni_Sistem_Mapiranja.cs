using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Alarmni_Sistem_Mapiranja : ClassMap<Alarmni_Sistem>
    {
        public Alarmni_Sistem_Mapiranja()
        {
            //TABELA
            Table("ALARMNI_SISTEM");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.ALARMNI_SISTEM_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Proizvodjac).Column("PROIZVODJAC");
            Map(x => x.Datum_Instalacije).Column("DATUM_INSTALACIJE");
            Map(x => x.Godina_Proizvodnje).Column("GODINA_PROIZVODNJE");
            Map(x => x.DTO_Flag).Column("DTO_FLAG");
            Map(x => x.Vertikalna_Rezolucija).Column("VERTIKALNA_REZ");
            Map(x => x.Horizontalna_Rezolucija).Column("HORIZONTALNA_REZ");
            Map(x => x.US_Flag).Column("US_FLAG");
            Map(x => x.OpsegFrekfencije).Column("OPSEG_FREKVENCIJE");
            Map(x => x.DP_Flag).Column("DP_FLAG");
            Map(x => x.Osetljivost).Column("OSETLJIVOST");

            //VEZE
            //N:M
            HasMany(x => x.Odrzavanja).KeyColumn("ID_ALARMNI_SISTEM").LazyLoad().Cascade.All().Inverse();
            //1:1
            //vezu sa Objektom smo naveli u tabeli Objekat kao Reference na Alarmni Sistem!
        }
    }
}
