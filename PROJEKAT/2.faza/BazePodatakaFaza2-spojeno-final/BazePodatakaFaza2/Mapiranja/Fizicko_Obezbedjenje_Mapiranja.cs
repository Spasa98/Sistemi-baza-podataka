using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Fizicko_Obezbedjenje_Mapiranja : SubclassMap<Fizicko_Obezbedjenje>
    {
        public Fizicko_Obezbedjenje_Mapiranja()
        {
            //TABELA
            Table("FIZICKO_OBEZBEDJENJE");

            //PRIMARY KEY
            KeyColumn("ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Borilacka_Vestina).Column("BORILACKA_VESTINA");
            Map(x => x.Vodja_Flag).Column("VODJA_FLAG");

            //VEZE
            //N:1
            References(x => x.Ekipa).Column("ID_EKIPA").LazyLoad();
        }
    }
}
