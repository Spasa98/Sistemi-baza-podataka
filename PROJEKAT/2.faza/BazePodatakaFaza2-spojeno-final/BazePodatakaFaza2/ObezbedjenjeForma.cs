using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using BazePodatakaFaza2.Entiteti;
using BazePodatakaFaza2.Forme;

namespace BazePodatakaFaza2
{
    public partial class Obezbedjenje : Form
    {
        public Obezbedjenje()
        {
            InitializeComponent();
        }

        private void cmdUcitajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Get<Zaposleni>(2);

                MessageBox.Show("Zaposleni ID=2: \n" + z.Ime + " " + z.Prezime + " " + z.Datum_Rodjenja.ToShortDateString());

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajTehnickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tehnicko_Lice t = (Tehnicko_Lice)s.Get<Zaposleni>(5);

                MessageBox.Show("Tehnicko lice ID=5: \n" + t.Ime + " " + t.Prezime + " " + t.Datum_Rodjenja.ToShortDateString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajMenadzera_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = (Menadzer)s.Get<Zaposleni>(1);

                MessageBox.Show("Menadzer ID=5: \n" + m.Ime + " " + m.Prezime + " " + m.Datum_Rodjenja.ToShortDateString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdMenadzerPokrivaGrad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery upit = s.CreateQuery("FROM Grad AS g WHERE g.Menadzer = 2");

				IList<Entiteti.Grad> gradovi = upit.List<Entiteti.Grad>();
                
                string poruka = "Gradove koje pokriva Menadzer sa ID=2 su: \n";
                
                foreach(Entiteti.Grad g in gradovi)
                {
                    poruka += g.Naziv + "\n";
                }

                MessageBox.Show(poruka);
                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdGradoviObuhvaceniRegCentar_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery upit = s.CreateQuery("FROM Grad AS g WHERE g.Regionalni_Centar = 0");

				IList<Entiteti.Grad> gradovi = upit.List<Entiteti.Grad>();

                string poruka = "Gradovi koji su obuhvaceni Regionalnim centrom sa ID=0 su: \n";

                foreach (Entiteti.Grad g in gradovi)
                {
                    poruka += g.Naziv + "\n";
                }

                MessageBox.Show(poruka);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdObjekatImaAlarmniSistem_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery upit = s.CreateQuery("FROM Objekat AS o");

                IList<Objekat> objekti = upit.List<Objekat>();

                string poruka = "Spisak: \n";

                foreach (Objekat o in objekti)
                {
                    poruka += "Objekat na adresi " + o.Adresa + ", alarmni sistem "+ o.Alarmni_Sistem.Proizvodjac + ", instaliran " + o.Alarmni_Sistem.Datum_Instalacije.ToShortDateString() + "\n";
                }

                MessageBox.Show(poruka);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQTehnickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Tehnicko_Lice> lica = from tl in s.Query<Tehnicko_Lice>()
                                                  where (tl.Oblast_Tehnike == "automatika")
                                                  orderby tl.ID
                                                  select tl;

                string poruka = "Tehnicka lica koja imaju oblast tehnike Automatika: \n";

                foreach (Tehnicko_Lice t in lica)
                {
                    poruka += t.Ime + " " + t.Prezime + "\n";
                }

                MessageBox.Show(poruka);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozila = s.Query<Vozilo>()
                                             .Where(v => (v.Model == "dzip" && v.Proizvodjac == "BMW"))
                                             .OrderBy(v => v.ID).ThenBy(v => v.Registarska_Oznaka)
                                             .Select(v => v);

                string poruka = "Pronadjena su vozila sa registracijama: \n";

                foreach (Vozilo vo in vozila)
                {
                    poruka += vo.Registarska_Oznaka + "\n";
                }

                MessageBox.Show(poruka);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdNativeSql_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT G.* FROM GRAD G");
                q.AddEntity(typeof(Entiteti.Grad));

				IList<Entiteti.Grad> gradovi = q.List<Entiteti.Grad>();

                string poruka = "Gradovi su: \n";

                foreach (Entiteti.Grad g in gradovi)
                {
                    poruka += g.Naziv.ToString() + ", ";
                }

                MessageBox.Show(poruka);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajAS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery upit = s.CreateQuery("FROM Alarmni_Sistem AS als");

                IList<Alarmni_Sistem> alarmi = upit.List<Alarmni_Sistem>();

                string poruka = "Alarmni sistemi su: \n";

                foreach (Alarmni_Sistem a in alarmi)
                {
                    poruka += a.Proizvodjac + " instaliran " + a.Datum_Instalacije.ToShortDateString() + "\n";
                }

                MessageBox.Show(poruka);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdRefreshGrad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

				Entiteti.Grad g = s.Get<Entiteti.Grad>(24);

                g.Naziv = "Sarajevo";

                s.Refresh(g);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajTelefonO_Click(object sender, EventArgs e)
        {
            DodajTelefonObjForma dodajTelObj = new DodajTelefonObjForma();
            dodajTelObj.Show();
        }

        private void cmdObrisiTelefonO_Click(object sender, EventArgs e)
        {
            ObrisiTelefonObjForma obrisiTelObj = new ObrisiTelefonObjForma();
            obrisiTelObj.Show();
        }

        private void cmdIzmeniTelefonO_Click(object sender, EventArgs e)
        {
            IzmeniTelefonObjForma izmeniTelObj = new IzmeniTelefonObjForma();
            izmeniTelObj.Show();
        }

        private void cmdDodajGrad_Click(object sender, EventArgs e)
        {
            DodajGradForma dodajGrad = new DodajGradForma();
            dodajGrad.Show();
        }

        private void cmdUcitajGradove_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
				Entiteti.Grad grad = s.Get<Entiteti.Grad>(30);
                MessageBox.Show("Grad ciji je ID " + grad.ID + " je: " + grad.Naziv + "\nMenadzer je: " + grad.Menadzer.Ime + " " + grad.Menadzer.Prezime + "\nGrad pripada regionalnom centru sa ID-jem: " + grad.Regionalni_Centar.ID);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdDodajObjekat_Click(object sender, EventArgs e)
        {
            DodajObjekatForma ucitaj = new DodajObjekatForma();
            ucitaj.Show();
        }

        private void cmdUcitajObjekte_Click(object sender, EventArgs e)
        {
            UcitajObjekatForma ucitaj = new UcitajObjekatForma();
            ucitaj.Show();
        }

        private void cmdDodajTehLice_Click(object sender, EventArgs e)
        {
            DodajTehnickoLiceForma dodajTehnickoLice = new DodajTehnickoLiceForma();
            dodajTehnickoLice.Show();
        }

        private void cmdDodajMenadzera_Click(object sender, EventArgs e)
        {
            DodajMenadzeraForma dodajMenadzera = new DodajMenadzeraForma();
            dodajMenadzera.Show();
        }

        private void cmdObrisiTehLice_Click(object sender, EventArgs e)
        {
            ObrisiTehnickoLice obrisiTL = new ObrisiTehnickoLice();
            obrisiTL.Show();
        }

        private void cmdIntervencijeObjektiEkipe_Click(object sender, EventArgs e)
        {
            IntervencijaEkipaObjekatForma ucitaj = new IntervencijaEkipaObjekatForma();
            ucitaj.Show();
        }

		private void cmdDodajVozilo_Click(object sender, EventArgs e)
		{
			DodajVozilo ucitaj = new DodajVozilo();
			ucitaj.Show();
		}

		private void cmdUcitajVozila_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				IQuery q = s.CreateQuery("from Vozilo as o where o.ID<=3");

				IList<Vozilo> vozilo = q.List<Vozilo>();
				
                string poruka = "Vozila: \n";
				
                foreach (Vozilo o in vozilo)
				{
					poruka += + o.ID + ", " + o.Registarska_Oznaka + ", " + o.Proizvodjac + " " + o.Tip + ", " + o.Model + ", Regionalni centar: " + o.Regionalni_Centar.ID + "\n";
                }
				
                MessageBox.Show(poruka);
				s.Close();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void MenadzerGrad_Click(object sender, EventArgs e)
		{
			Forme.GradForma prikazi = new Forme.GradForma();
			prikazi.Show();
		}

        private void cmdEkipaDuziVozilo_Click(object sender, EventArgs e)
        {
            Forme.KreirajEkipaDuziVoziloForma prikazi = new Forme.KreirajEkipaDuziVoziloForma();
            prikazi.Show();
        }

        private void cmdEkipaInterveniseObj_Click(object sender, EventArgs e)
        {
            Forme.KreirajEkipaInterveniseObjekatForma prikazi = new Forme.KreirajEkipaInterveniseObjekatForma();
            prikazi.Show();
        }
	}
}
