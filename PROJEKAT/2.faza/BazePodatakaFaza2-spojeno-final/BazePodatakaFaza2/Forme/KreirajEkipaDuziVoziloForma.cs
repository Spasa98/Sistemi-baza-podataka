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
    public partial class KreirajEkipaDuziVoziloForma : Form
    {
        public IList<Ekipa> listaEkipa { get; set; }

        public IList<Vozilo> listaVozila { get; set; }
        
        public KreirajEkipaDuziVoziloForma()
        {
            InitializeComponent();

            ucitajVozila();
            ucitajEkipe();
        }

        private void ucitajEkipe()
        {
            try
            {
                ISession session = DataLayer.GetSession();
                IQuery query = session.CreateQuery("from Ekipa");

                listaEkipa = query.List<Ekipa>();

                foreach (var e in listaEkipa)
                {
                    cbEkipa.Items.Add(e.Naziv);
                }

                session.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ucitajVozila()
        {
            try
            {
                ISession session = DataLayer.GetSession();
                IQuery query = session.CreateQuery("from Vozilo");

                listaVozila = query.List<Vozilo>();

                foreach (var v in listaVozila)
                {
                    cbVozilo.Items.Add(v.Registarska_Oznaka);
                }

                session.Close();
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
                ISession session = DataLayer.GetSession();

                Duzi temp = new Duzi();

                temp.Ekipa = listaEkipa[cbEkipa.SelectedIndex];
                temp.Vozilo = listaVozila[cbVozilo.SelectedIndex];

                temp.Duzi_Od = duziOd.Value;
                temp.Duzi_Do = duziDo.Value;

                session.Save(temp);
                session.Flush();

                session.Close();

                MessageBox.Show("Vozilo je zaduzeno!");
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
