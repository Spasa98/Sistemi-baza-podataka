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
	
	public partial class GradForma : Form
	{
		public GradForma()
		{
			InitializeComponent();
		}
		public void Popuni()
		{
			try
			{		
				listView1.Items.Clear();
				ISession s = DataLayer.GetSession();
				IEnumerable<Grad> Gradovi = from o in s.Query<Grad>()orderby o.ID select o;
				if (LBpom.Text == "prikazisvegradove")
				{

				}
				if (LBpom.Text == "prikazipomenadzeru")
				{
					Gradovi = from o in s.Query<Grad>()
												where o.Menadzer.ID == (int)nudID.Value
												select o;
				}
				if (Gradovi.Count() == 0)
				{
					throw new Exception("Ne postoji menadzer sa ovim ID-jem.");
				}
				foreach (Grad g in Gradovi)
				{
					ListViewItem item = new ListViewItem(new string[] { g.ID.ToString(), g.Naziv, g.Regionalni_Centar.ID.ToString(), g.Menadzer.ID.ToString() });
					listView1.Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void tbPrikaziGradovePoMenadzeru_Click(object sender, EventArgs e)
		{
			LBpom.Text = "prikazipomenadzeru";
			Popuni();
		}


		private void prikaziSveGradove_Click(object sender, EventArgs e)
		{
			LBpom.Text = "prikazisvegradove";
			Popuni();
		}


		private void GradForma_Load(object sender, EventArgs e)
		{
			Popuni();
		}


		private void DodajGrad_Click(object sender, EventArgs e)
		{
			DodajGradForma dodajGrad = new DodajGradForma();
			dodajGrad.Show();
		}


		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				//Grad grad = new Grad();

				Grad g = s.Load<Grad>((int)nudIDgrada.Value);
				if (g == null)
				{
					throw new Exception("Ne postoji grad sa zadatim ID-jem.");
				}
				Grad g2 = s.Load<Grad>((int)nudIDgrada.Value);
				if (g2 == null)
				{
					throw new Exception("Ne postoji grad sa zadatim ID-jem.");
				}
				if (checkBox1.Checked == true)
				{
					Menadzer men = s.Load<Menadzer>(g.Menadzer.ID);
					Menadzer m = s.Load<Menadzer>((int)nudNoviMenadzer.Value);
					if (m == null)
					{
						throw new Exception("Ne postoji menadzer sa zeljenim ID-jem.");
					}
					foreach (Grad gr in men.Pokriva_Gradove)
					{
						if (gr == g)
						{
							g.Menadzer = m;
						}
					}
				}
				if (checkBox2.Checked == true)
				{
					Regionalni_Centar rc = s.Load<Regionalni_Centar>(g2.Regionalni_Centar.ID);
					Regionalni_Centar regc = s.Load<Regionalni_Centar>((int)nudRC.Value);
					if (regc == null)
					{
						throw new Exception("Ne postoji RC sa zeljenim ID-jem.");
					}
					foreach (Grad gr in rc.Obuhvata_Gradove)
					{
						if (gr == g2)
						{
							g2.Regionalni_Centar = regc;
						}
					}
				}
				if (checkBox1.Checked ==false && checkBox2.Checked ==false)
				{
					throw new Exception("Nema novih promena.");
				}

				s.Update(g);
				s.Update(g2);
				s.Flush();
				s.Close();
				Popuni();
				MessageBox.Show("Uspesno ste izmenili grad!");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void btnObrisi_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Grad g = s.Get<Grad>((int)nudIDgrada.Value);
				if (g == null)
				{
					throw new Exception("Ne postoji grad sa ovim ID-jem.");
				}
				s.Delete(g);
				//s.Delete("from Odeljenje");
				s.Flush();
				s.Close();
				MessageBox.Show("Uspesno ste izbrisali grad.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				nudNoviMenadzer.Enabled = true;
			}
			else
			{
				nudNoviMenadzer.Enabled = false;
			}
		}


		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
			{
				nudRC.Enabled = true;
			}
			else
			{
				nudRC.Enabled = false;
			}
		}

		private void nudID_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnIzmeniIme_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				
				Grad g = s.Get<Grad>((int)nudIDgrada.Value);
				if (g == null)
				{
					throw new Exception("Ne postoji grad sa zadatim ID-jem.");
				}
				List<string> nazivG = s.Query<Grad>().Select(x => x.Naziv).ToList();
				foreach (string ng in nazivG)
				{
					if (ng == tbNovoIme.Text)
					{
						throw new Exception("Vec postoji grad sa ovim imenom.");
					}
				}
				g.Naziv = tbNovoIme.Text;
				s.Update(g);
				s.Flush();
				s.Close();
				Popuni();
				MessageBox.Show("Uspesno ste izmenili grad!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
}

	}
}
