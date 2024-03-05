using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Smena_Mapiranja : ClassMap<Smena>
    {
        public Smena_Mapiranja()
        {
            //TABELA
            Table("SMENA");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.SMENA_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Vreme_Pocetka).Column("VREME_POCETKA");
            Map(x => x.Vreme_Kraja).Column("VREME_KRAJA");

            //VEZE
            //M:N
            HasManyToMany(x => x.SmenaObilaziObjekat)
                .Table("OBILAZI")
                .ParentKeyColumn("ID_SMENA")
                .ChildKeyColumn("ID_OBJEKAT")
                .Cascade.All();
            //M:N
            HasManyToMany(x => x.SmenuRadiEkipa)
                .Table("RADI")
                .ParentKeyColumn("ID_SMENA")
                .ChildKeyColumn("ID_EKIPA")
                //.Inverse()
                .Cascade.All();
        }
    }
}
