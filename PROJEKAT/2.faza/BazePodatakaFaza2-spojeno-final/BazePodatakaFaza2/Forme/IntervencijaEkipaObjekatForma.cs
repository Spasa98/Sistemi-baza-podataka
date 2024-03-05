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
    public partial class IntervencijaEkipaObjekatForma : Form
    {
        public IntervencijaEkipaObjekatForma()
        {
            InitializeComponent();
        }

		public void popuniPodacima(int pomocna)
		{
			try
			{
				listView1.Items.Clear();
				ISession s = DataLayer.GetSession();
				IEnumerable<Intervencija> intervencije = from o in s.Query<Intervencija>() select o;
				if (pomocna == 0)
				{

				}
				if (pomocna == 1)
				{
					Ekipa e = s.Get<Ekipa>((int)numericUpDown1.Value);
					if (e == null)
					{
						throw new Exception("Ne postoji ekipa sa ovim ID-jem.");
					}
					intervencije = intervencije.Where(p => p.Ekipa == e);
				}
				if (pomocna == 2)
				{
					Objekat e = s.Get<Objekat>((int)numericUpDown2.Value);
					if (e == null)
					{
						throw new Exception("Ne postoji objekat sa ovim ID-jem.");
					}
					/*else if (e.Intervencije == null)
					{
						throw new Exception("Na ovom objektu nije izvrsena intervencija");
					}*/

					intervencije = intervencije.Where(p => p.Objekat == e);
				}


				foreach (Intervencija i in intervencije)
				{
					ListViewItem item = new ListViewItem(new string[] { i.Ekipa.Naziv, i.Opis, i.Datum.ToShortDateString(), i.Vreme, i.Objekat.Adresa, i.Objekat.Tip });
					listView1.Items.Add(item);
				}
				listView1.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSveIntervencije_Click(object sender, EventArgs e)
        {
			this.popuniPodacima(0);
		}

        private void btnInervencijaPoObjektnu_Click(object sender, EventArgs e)
        {
			this.popuniPodacima(2);
		}

        private void btnIntervencijaPoekipi_Click(object sender, EventArgs e)
        {
			this.popuniPodacima(1);
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
