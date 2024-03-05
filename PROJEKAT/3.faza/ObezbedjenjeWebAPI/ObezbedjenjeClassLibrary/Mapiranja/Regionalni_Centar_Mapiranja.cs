using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Regionalni_Centar_Mapiranja : ClassMap<Regionalni_Centar>
    {
        public Regionalni_Centar_Mapiranja()
        {
            //TABELA
            Table("REGIONALNI_CENTAR");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.REGIONALNI_CENTAR_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Adresa).Column("ADRESA");

            //VEZE
            //1:N
            HasMany(x => x.Obuhvata_Gradove).KeyColumn("ID_REGIONALNI_CENTAR").LazyLoad().Cascade.All().Inverse();
            //1:N
            HasMany(x => x.Telefoni_RC).KeyColumn("ID_REGIONALNI_CENTAR").LazyLoad().Cascade.All().Inverse();
            //1:N
            HasMany(x => x.Vozila).KeyColumn("ID_REGIONALNI_CENTAR").Cascade.All().Inverse();
            //1:1
            //vezu sa Menadzerom smo naveli u tabeli Menadzer kao Reference na Regionalni Centar!
        }
    }
}
