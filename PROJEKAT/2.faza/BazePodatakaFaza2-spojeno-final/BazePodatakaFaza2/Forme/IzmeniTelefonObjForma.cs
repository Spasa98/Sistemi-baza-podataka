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
    public partial class IzmeniTelefonObjForma : Form
    {
        public IList<Objekat> Objekti { get; set; }
        public IList<Telefon_O> ListaBrojeva { get; set; }

        public IzmeniTelefonObjForma()
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

        private void ucitajTelefoneIzabranogObjekta()
        {
            try
            {
				comboBox2.Items.Clear();
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("FROM Telefon_O");

                ListaBrojeva = q.List<Telefon_O>();

                foreach (var t in ListaBrojeva)
                {
                    if (t.Objekat.ID == Objekti[comboBox1.SelectedIndex].ID)
                    {
                        comboBox2.Items.Add(t.Telefon);
					}
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
				if (checkBox1.Checked==false)
				{
					IQuery q = s.CreateQuery("UPDATE Telefon_O t  SET t.Telefon = ? WHERE t.Telefon = ?");

					q.SetString(0, textBox1.Text);
					q.SetString(1, comboBox2.Items[comboBox2.SelectedIndex].ToString());
					q.ExecuteUpdate();
					MessageBox.Show("Telefon objekta promenjen.");
				}
				if (checkBox1.Checked == true)
				{
					Telefon_O telefon = new Telefon_O();
					Objekat noviGrad = s.Query<Objekat>().Where(x => x.ID == (int)comboBox1.SelectedItem)
												   .Select(x => x)
										    	   .FirstOrDefault();
					telefon.Telefon = textBox1.Text;
					telefon.Objekat = noviGrad;
					s.Update(telefon);
					MessageBox.Show("Telefon objekta dodat.");
				}
				//s.Update(q);
				s.Flush();
                s.Close();
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajTelefoneIzabranogObjekta();
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				btnIzmeni.Text = "Dodaj";
			}
			else
			{
				btnIzmeni.Text = "Izmeni";
			}
		}
	}
}
