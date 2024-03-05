using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Vozilo_Mapiranja : ClassMap<Vozilo>
    {
        public Vozilo_Mapiranja()
        {
            //TABELA
            Table("VOZILO");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.VOZILO_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Registarska_Oznaka).Column("REGISTARSKA_OZNAKA");
            Map(x => x.Model).Column("MODEL");
            Map(x => x.Proizvodjac).Column("PROIZVODJAC");
            Map(x => x.Tip).Column("TIP");
            Map(x => x.Boja).Column("BOJA");

            //VEZE
            //N:1
            References(x => x.Regionalni_Centar).Column("ID_REGIONALNI_CENTAR");
            //N:M
            HasMany(x => x.VoziloDuziEkipa).KeyColumn("ID_VOZILO").Cascade.All();
        }
    }
}
