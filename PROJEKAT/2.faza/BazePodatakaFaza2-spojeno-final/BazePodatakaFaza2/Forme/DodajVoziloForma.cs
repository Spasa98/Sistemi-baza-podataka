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
    public partial class DodajVozilo : Form
    {

        public DodajVozilo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DodajVoziloForma_Load(object sender, EventArgs e)
        {
			ISession sesija = DataLayer.GetSession();
			List<int> IDvozila = sesija.Query<Regionalni_Centar>().Select(x => x.ID).ToList();

			foreach (int v in IDvozila)
			{
				ListViewItem item = new ListViewItem(new string[] { v.ToString() });
				listView1.Items.Add(item);
			}
			listView1.Refresh();
		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

		private void btnDodajVozilo_Click(object sender, EventArgs e)
		{
			try
			{
				//int value = Convert.ToInt32(comboBox1.SelectedValue);
				//Console.WriteLine(value);
				ISession s = DataLayer.GetSession();
				Regionalni_Centar reg = s.Get<Regionalni_Centar>((int)nudRegCen.Value);
				if (reg == null)
				{
					throw new Exception("Ne postoji regionalni centar sa ovim ID-jem.");
				}
				List<Vozilo> v = s.Query<Vozilo>().ToList();
				foreach (Vozilo vozilo in v)
				{
					if (tbRegOznaka.Text == vozilo.Registarska_Oznaka)
						throw new Exception("Vec postoji vozilo sa ovom registarskom oznakom.");
				}
				Vozilo dodajVozilo = new Vozilo
				{
					Registarska_Oznaka = tbRegOznaka.Text,
					Model = tbModel.Text,
					Proizvodjac = tbProizvodjac.Text,
					Tip=tbTip.Text,
					Boja=tbBoja.Text,
					Regionalni_Centar = reg,
					
				};
				s.Save(dodajVozilo);
				s.Flush();
				s.Close();
				MessageBox.Show("Uspesno ste dodali vozilo!");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void nudRegCen_ValueChanged(object sender, EventArgs e)
		{
			
		}
	}
}
