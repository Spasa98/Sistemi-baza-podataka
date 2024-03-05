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
    public partial class ObrisiTehnickoLice : Form
    {
        public IList<Tehnicko_Lice> tehnickaLica { get; set; }

        public ObrisiTehnickoLice()
        {
            InitializeComponent();
            ucitajTehnickaLica();
        }

        private void ucitajTehnickaLica()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("FROM Tehnicko_Lice");

                tehnickaLica = q.List<Tehnicko_Lice>();

                foreach (var lica in tehnickaLica)
                {
                    comboBox1.Items.Add(lica.ID);
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
                Tehnicko_Lice tl = s.Get<Tehnicko_Lice>((int)numericUpDown1.Value);
                
                if(tl == null)
                {
                    throw new Exception("Ne postoji!");
                }
                
                s.Delete(tl);
                s.Flush();
                s.Close();
                
                MessageBox.Show("Tehnicko lice uspesno obrisano.");

                //IQuery q = s.CreateQuery("DELETE FROM Tehnicko_Lice tl WHERE tl.ID = ?");

                //q.SetParameter(0, (int)comboBox1.SelectedItem);
                //q.SetParameter(0, (int)comboBox1.Items[comboBox1.SelectedIndex].ToString());
                //s.Delete(q);
                //MessageBox.Show("Tehnicko lice obrisano.");

                //s.Flush();
                //s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
