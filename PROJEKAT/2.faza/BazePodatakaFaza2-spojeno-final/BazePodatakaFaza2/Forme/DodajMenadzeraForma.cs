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
    public partial class DodajMenadzeraForma : Form
    {
        public DodajMenadzeraForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Regionalni_Centar rc = new Entiteti.Regionalni_Centar()
                {
                    Adresa = this.textBox1.Text
                };

                char pol = 'M';
                if (!this.radioButton4.Checked)
                    pol = 'Z';

                Menadzer m = new Menadzer()
                {
                    JMBG = Convert.ToInt64(this.textBox7.Text),
                    Ime = this.textBox6.Text,
                    Prezime = this.textBox4.Text,
                    Datum_Rodjenja = this.dateTimePicker1.Value,
                    Pol = pol,
                    Regionalni_Centar = rc
                };

                s.Save(m);

                s.Flush();
                s.Close();

                MessageBox.Show("Menadzer je dodat!");
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
