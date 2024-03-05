using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Zaposleni_Mapiranja : ClassMap<Zaposleni>
    {
        public Zaposleni_Mapiranja()
        {
            //TABELA
            Table("ZAPOSLENI");

            //PRIMARY KEY
            //generisanje kljuca uz pomoc sekvence
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16473.ZAPOSLENI_ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.JMBG).Column("JMBG");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Pol).Column("POL");
            Map(x => x.Datum_Rodjenja).Column("DATUM_RODJENJA");
        }
    }
}
