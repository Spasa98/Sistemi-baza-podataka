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
    public partial class DodajObjekatForma : Form
    {
        public DodajObjekatForma()
        {
            InitializeComponent();
        }

        private void btnDodajObjekat_Click(object sender, EventArgs e)
        {
			try
			{
				ISession s = DataLayer.GetSession();

				//Objekat o = new Objekat();
				Alarmni_Sistem alsis = new Alarmni_Sistem();
				if (cbDP.Checked)
				{
					alsis.DP_Flag = true;
					alsis.Osetljivost = (int)nudOsetljivost.Value;
				}
				else
				{
					alsis.DP_Flag = false;
				}
				if (cbDTO.Checked)
				{
					alsis.DTO_Flag = true;
					alsis.Vertikalna_Rezolucija = (int)nudVertikalna.Value;
					alsis.Horizontalna_Rezolucija = (int)nudHorizontalna.Value;
				}
				else
				{
					alsis.DTO_Flag = false;
				}
				if (cbUS.Checked)
				{
					alsis.US_Flag = true;
					alsis.OpsegFrekfencije = tbOpsegFrek.Text;
				}
				else
				{
					alsis.US_Flag = false;
				}
				if (cbDP.Checked || cbDTO.Checked || cbUS.Checked)
				{
					alsis.Proizvodjac = tbProizvodjac.Text;
					alsis.Datum_Instalacije = dateTimePicker1.Value;
					alsis.Godina_Proizvodnje = (int)nudGodProiz.Value;
				}
				else
				{
					throw new Exception("Niste odobarali ni jedan alarmni sistem.");
				}

				Objekat dodajObjekat = new Objekat
				{
					Adresa = tbAdresa.Text,
					Tip = tbTip.Text,
					Povrsina = (int)nudPovrsina.Value,
					Alarmni_Sistem = alsis
				};
				s.Save(dodajObjekat);
				s.Flush();
				s.Close();
				MessageBox.Show("Uspesno ste dodali objekat!");
				this.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

        private void cbDTO_CheckedChanged(object sender, EventArgs e)
        {
			nudHorizontalna.Enabled = true;
			nudVertikalna.Enabled = true;
		}

        private void cbUS_CheckedChanged(object sender, EventArgs e)
        {
			tbOpsegFrek.Enabled = true;
		}

        private void cbDP_CheckedChanged(object sender, EventArgs e)
        {
			nudOsetljivost.Enabled = true;
		}
    }
}
