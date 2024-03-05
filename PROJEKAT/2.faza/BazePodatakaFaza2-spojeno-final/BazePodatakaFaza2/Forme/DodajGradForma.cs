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
    public partial class DodajGradForma : Form
    {
        public DodajGradForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
			try
			{
				//int value = Convert.ToInt32(comboBox1.SelectedValue);
				//Console.WriteLine(value);
				ISession sesija = DataLayer.GetSession();
				Regionalni_Centar reg = sesija.Get<Regionalni_Centar>((int)nudRegCentar.Value);
				
				if (reg == null)
				{
					throw new Exception("Ne postoji regionalni centar sa ovim ID-jem.");
				}

				Menadzer OBJmenadzer = new Menadzer();
				
				List<Menadzer> m = sesija.Query<Menadzer>().ToList();
				
				foreach (Menadzer menadzer in m)
				{
					if (menadzer.Regionalni_Centar == reg)
						OBJmenadzer = menadzer;
				}

				Grad dodajGrad = new Grad
				{
					Naziv = tb_imegrada.Text,
					Regionalni_Centar = reg,
					Menadzer = OBJmenadzer
				};

				sesija.Save(dodajGrad);
				sesija.Flush();
				sesija.Close();
				MessageBox.Show("Uspesno ste dodali grad!");
				this.Close();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}
    }
}
