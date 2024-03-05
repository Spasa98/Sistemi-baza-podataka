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
    public partial class DodajTelefonObjForma : Form
    {
        public IList<Objekat> Objekti { get; set; }

        public DodajTelefonObjForma()
        {
            InitializeComponent();
            ucitajObjekte();
        }

        private void ucitajObjekte()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("FROM Objekat");

                Objekti = q.List<Objekat>();

                foreach (var o in Objekti)
                {
                    comboBox1.Items.Add(o.ID);
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

                Objekat o = s.Get<Objekat>(Convert.ToInt32(comboBox1.Text));

                Telefon_O to = new Telefon_O
                {
                    Telefon = this.textBox1.Text,
                    Objekat = o
                };

                s.Save(to);
                s.Flush();
                s.Close();

                MessageBox.Show("Telefon za objekat sa ID-jem " + o.ID + " dodat!");
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
