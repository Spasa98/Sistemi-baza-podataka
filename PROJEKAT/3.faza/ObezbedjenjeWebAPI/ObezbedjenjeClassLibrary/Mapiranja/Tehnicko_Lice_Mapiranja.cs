using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ObezbedjenjeClassLibrary.Entiteti;

namespace ObezbedjenjeClassLibrary.Mapiranja
{
    class Tehnicko_Lice_Mapiranja : SubclassMap<Tehnicko_Lice>
    {
        public Tehnicko_Lice_Mapiranja()
        {
            //TABELA
            Table("TEHNICKO_LICE");

            //PRIMARY KEY
            //ID koji je primarni kljuc Tehnickog_Lica je zapravo primerni kljuc Zaposlenog
            //KeyColumn znaci da kljucna vrednost cija ce se vrednost iskoristiti za uparivanje
            //sa vrednoscu kolone primarnog kljuca Nadklase je zapravo njegova kolona ID
            KeyColumn("ID");

            //PRESLIKAVANJE ATRIBUTA
            Map(x => x.Oblast_Tehnike).Column("OBLAST_TEHNIKE");
            Map(x => x.Strucna_Sprema).Column("STRUCNA_SPREMA");

            //VEZE
            //M:N
            HasMany(x => x.Lista_Odrzavanja).KeyColumn("ID_TEHNICKO_LICE").LazyLoad().Cascade.All().Inverse();
            //Inverse se stavlja samo na jednu stranu veze
            //To znaci da ce Tehnicko lice voditi racuna o medjusobnoj vezi kada se menja
        }
    }
}
