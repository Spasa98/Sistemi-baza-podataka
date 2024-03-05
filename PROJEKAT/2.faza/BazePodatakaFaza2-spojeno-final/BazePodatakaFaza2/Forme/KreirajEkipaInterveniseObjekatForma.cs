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

namespace BazePodatakaFaza2.Forme
{
    public partial class KreirajEkipaInterveniseObjekatForma : Form
    {
        public IList<Ekipa> listaEkipa { get; set; }

        public IList<Objekat> listaObjekata { get; set; }

        public KreirajEkipaInterveniseObjekatForma()
        {
            InitializeComponent();
            ucitajEkipe();
            ucitajObjekte();
        }

        private void ucitajEkipe()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery query = s.CreateQuery("from Ekipa");

                listaEkipa = query.List<Ekipa>();

                foreach (var e in listaEkipa)
                {
                    cbEkipa.Items.Add(e.Naziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ucitajObjekte()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery query = s.CreateQuery("from Objekat");

                listaObjekata = query.List<Objekat>();

                foreach (var o in listaObjekata)
                {
                    cbObjekat.Items.Add(o.Adresa);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Intervencija inter = new Intervencija();

                inter.Objekat = listaObjekata[cbObjekat.SelectedIndex];
                inter.Ekipa = listaEkipa[cbEkipa.SelectedIndex];

                inter.Datum = date.Value;
                inter.Vreme = tbVreme.Text;
                inter.Opis = tbOpis.Text;

                s.Save(inter);
                s.Flush();

                s.Close();

                MessageBox.Show("Uspesno je intervenisan objekat!");
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
