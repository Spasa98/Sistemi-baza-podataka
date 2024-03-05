using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazePodatakaFaza2.Entiteti;

namespace BazePodatakaFaza2.Mapiranja
{
    class Menadzer_Mapiranja : SubclassMap<Menadzer>
    {
        public Menadzer_Mapiranja()
        {
            //TABELA
            Table("MENADZER");

            //PRIMARY KEY
            KeyColumn("ID");

            //VEZE
            //1:1 veza sa Regionalnim Centrom
            References(x => x.Regionalni_Centar).Column("ID_REGIONALNI_CENTAR").LazyLoad().Cascade.All();
            //1:N
            HasMany(x => x.Pokriva_Gradove).KeyColumn("ID_MENADZER").LazyLoad().Cascade.All().Inverse();
        }
    }
}
