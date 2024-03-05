using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Ekipa_Mapiranja : ClassMap<Ekipa>
    {
        public Ekipa_Mapiranja()
        {
            //TABELA
            Table("EKIPA");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.EKIPA_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Naziv).Column("NAZIV");

            //VEZE
            //M:N
            HasManyToMany(x => x.EkipaRadiUSmeni)
                .Table("RADI")
                .ParentKeyColumn("ID_EKIPA")
                .ChildKeyColumn("ID_SMENA")
                .Cascade.All();
            //M:N
            HasManyToMany(x => x.EkipaZaduzenaZaObjekat)
                .Table("ZADUZENA")
                .ParentKeyColumn("ID_EKIPA")
                .ChildKeyColumn("ID_OBJEKAT")
                .Cascade.All();
            //M:N
            HasMany(x => x.EkipaDuziVozila).Table("ID_EKIPA").Cascade.All().Inverse();
            //1:N
            HasMany(x => x.FizickaObezbedjenja).KeyColumn("ID_EKIPA").Cascade.All().Inverse();
            //M:N
            HasMany(x => x.Intervencije).Table("ID_EKIPA").Cascade.All().Inverse();
            }
    }
}
