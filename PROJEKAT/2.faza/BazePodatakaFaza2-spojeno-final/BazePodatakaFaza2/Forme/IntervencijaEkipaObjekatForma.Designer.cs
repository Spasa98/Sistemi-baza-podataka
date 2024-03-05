
namespace BazePodatakaFaza2.Forme
{
    partial class IntervencijaEkipaObjekatForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.listView1 = new System.Windows.Forms.ListView();
			this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Vreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.btnIntervencijaPoekipi = new System.Windows.Forms.Button();
			this.btnInervencijaPoObjektnu = new System.Windows.Forms.Button();
			this.btnSveIntervencije = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Opis,
            this.Datum,
            this.Vreme,
            this.adresa,
            this.Tip});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(10, 11);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(661, 326);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// Naziv
			// 
			this.Naziv.Text = "Naziv Ekipe";
			this.Naziv.Width = 84;
			// 
			// Opis
			// 
			this.Opis.Text = "Opis";
			this.Opis.Width = 94;
			// 
			// Datum
			// 
			this.Datum.Text = "Datum intervencije";
			this.Datum.Width = 132;
			// 
			// Vreme
			// 
			this.Vreme.Text = "Vreme intervencije";
			this.Vreme.Width = 122;
			// 
			// adresa
			// 
			this.adresa.Text = "Adresa objekta";
			this.adresa.Width = 120;
			// 
			// Tip
			// 
			this.Tip.Text = "Tip objekta";
			this.Tip.Width = 111;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(747, 93);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(680, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "ID Objekta:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(748, 223);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(677, 226);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID Ekipe:";
			// 
			// btnIntervencijaPoekipi
			// 
			this.btnIntervencijaPoekipi.Location = new System.Drawing.Point(680, 267);
			this.btnIntervencijaPoekipi.Name = "btnIntervencijaPoekipi";
			this.btnIntervencijaPoekipi.Size = new System.Drawing.Size(188, 69);
			this.btnIntervencijaPoekipi.TabIndex = 11;
			this.btnIntervencijaPoekipi.Text = "Vrati inervencije odredjene ekipe";
			this.btnIntervencijaPoekipi.UseVisualStyleBackColor = true;
			this.btnIntervencijaPoekipi.Click += new System.EventHandler(this.btnIntervencijaPoekipi_Click);
			// 
			// btnInervencijaPoObjektnu
			// 
			this.btnInervencijaPoObjektnu.Location = new System.Drawing.Point(681, 132);
			this.btnInervencijaPoObjektnu.Name = "btnInervencijaPoObjektnu";
			this.btnInervencijaPoObjektnu.Size = new System.Drawing.Size(187, 71);
			this.btnInervencijaPoObjektnu.TabIndex = 10;
			this.btnInervencijaPoObjektnu.Text = "Vrati intervencije za odredjeni objekat";
			this.btnInervencijaPoObjektnu.UseVisualStyleBackColor = true;
			this.btnInervencijaPoObjektnu.Click += new System.EventHandler(this.btnInervencijaPoObjektnu_Click);
			// 
			// btnSveIntervencije
			// 
			this.btnSveIntervencije.Location = new System.Drawing.Point(680, 10);
			this.btnSveIntervencije.Name = "btnSveIntervencije";
			this.btnSveIntervencije.Size = new System.Drawing.Size(188, 68);
			this.btnSveIntervencije.TabIndex = 9;
			this.btnSveIntervencije.Text = "Vrati sve intervencije";
			this.btnSveIntervencije.UseVisualStyleBackColor = true;
			this.btnSveIntervencije.Click += new System.EventHandler(this.btnSveIntervencije_Click);
			// 
			// IntervencijaEkipaObjekatForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 345);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnIntervencijaPoekipi);
			this.Controls.Add(this.btnInervencijaPoObjektnu);
			this.Controls.Add(this.btnSveIntervencije);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "IntervencijaEkipaObjekatForma";
			this.Text = "Lista svih Intervencija na Objektima sa Ekipama";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Vreme;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIntervencijaPoekipi;
        private System.Windows.Forms.Button btnInervencijaPoObjektnu;
        private System.Windows.Forms.Button btnSveIntervencije;
    }
}