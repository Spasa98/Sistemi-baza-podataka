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
    public partial class UcitajObjekatForma : Form
    {
        public UcitajObjekatForma()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
			try
			{
				ISession s = DataLayer.GetSession();
				Objekat o = s.Get<Objekat>((int)nudIDObj.Value);
				if (o == null)
				{
					throw new Exception("Ne postoji regionalni centar sa ovim ID-jem.");
				}
				panel1.Visible = false;
				panel3.Visible = false;
				panel4.Visible = false;
				panelPrikaz.Visible = true;


				lblVratiPovrsinu.Text = o.Povrsina.ToString(o.Povrsina + " m2");
				lblVratiAdresu.Text = o.Adresa.ToString();
				lblVratiTipObjekta.Text = o.Tip.ToString();
				if (o.Alarmni_Sistem != null)
				{
					panel5.Visible = true;
					panelAlarmniSis.Visible = true;
					lblVratiIDAlarmniSis.Text = o.Alarmni_Sistem.ID.ToString();
					lblVratiProizvodjac.Text = o.Alarmni_Sistem.Proizvodjac.ToString();
					lblVratiGodinu.Text = o.Alarmni_Sistem.Godina_Proizvodnje.ToString();
					lblVratiDaum.Text = o.Alarmni_Sistem.Datum_Instalacije.ToShortDateString();
					if (o.Alarmni_Sistem.DP_Flag == true)
					{
						panel3.Visible = true;
						lblOsetljivost.Text = o.Alarmni_Sistem.Osetljivost.ToString();
					}
					if (o.Alarmni_Sistem.DTO_Flag == true)
					{
						panel4.Visible = true;
						lbVR.Text = o.Alarmni_Sistem.Vertikalna_Rezolucija.ToString();
						lbHR.Text = o.Alarmni_Sistem.Horizontalna_Rezolucija.ToString();
					}
					if (o.Alarmni_Sistem.US_Flag == true)
					{
						panel1.Visible = true;
						label4.Text = o.Alarmni_Sistem.OpsegFrekfencije.ToString();
					}
				}

				s.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
    }
}
