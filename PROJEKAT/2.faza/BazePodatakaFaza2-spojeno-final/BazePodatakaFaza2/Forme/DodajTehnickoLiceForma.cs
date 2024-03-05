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
    public partial class DodajTehnickoLiceForma : Form
    {
        public DodajTehnickoLiceForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                char pol = 'M';
                if (!this.radioButton1.Checked)
                    pol = 'Z';

                Tehnicko_Lice tl = new Tehnicko_Lice()
                {
                    JMBG = Convert.ToInt64(this.textBox1.Text),
                    Ime = this.textBox2.Text,
                    Prezime = this.textBox3.Text,
                    Datum_Rodjenja = this.dateTimePicker1.Value,
                    Pol = pol,
                    Oblast_Tehnike = this.textBox4.Text,
                    Strucna_Sprema = this.textBox5.Text
                };

                s.Save(tl);

                s.Flush();
                s.Close();

                MessageBox.Show("Tehničko lice je dodato!");
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
