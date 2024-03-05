using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Objekat_Mapiranja : ClassMap<Objekat>
    {
        public Objekat_Mapiranja()
        {
            //TABELA
            Table("OBJEKAT");

            //PRIMARY KEY
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.OBJEKAT_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Tip).Column("TIP_OBJEKTA");
            Map(x => x.Povrsina).Column("POVRSINA");

            //VEZE
            //1:1 veza sa Alarmnim Sistemom
            References(x => x.Alarmni_Sistem).Column("ID_ALARMNI_SISTEM").Cascade.All();
            //M:N
            HasManyToMany(x => x.ObjekatObilaziSmena)
                .Table("OBILAZI")
                .ParentKeyColumn("ID_OBJEKAT")
                .ChildKeyColumn("ID_SMENA")
                //.Inverse()
                .Cascade.All();
            //M:N
            HasManyToMany(x => x.ZaObjekatZaduzenaEkipa)
                .Table("ZADUZENA")
                .ParentKeyColumn("ID_OBJEKAT")
                .ChildKeyColumn("ID_EKIPA")
                //.Inverse()
                .Cascade.All();
            //1:N
            HasMany(x => x.Telefoni_Objekta).KeyColumn("ID_OBJEKAT");//.LazyLoad().Cascade.All().Inverse();
            //M:N
            HasMany(x => x.Intervencije).KeyColumn("ID_OBJEKAT").Cascade.All().Inverse();
        }
    }
}
