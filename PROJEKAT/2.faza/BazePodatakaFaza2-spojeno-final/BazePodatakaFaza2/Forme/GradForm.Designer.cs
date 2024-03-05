namespace BazePodatakaFaza2.Forme
{
	partial class GradForma
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
			this.label1 = new System.Windows.Forms.Label();
			this.nudID = new System.Windows.Forms.NumericUpDown();
			this.listView1 = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.IDRegCen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DodajGrad = new System.Windows.Forms.Button();
			this.tbPrikaziGradovePoMenadzeru = new System.Windows.Forms.Button();
			this.prikaziSveGradove = new System.Windows.Forms.Button();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.LBpom = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbNovoIme = new System.Windows.Forms.TextBox();
			this.btnIzmeniIme = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.nudIDgrada = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.nudRC = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.nudNoviMenadzer = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudIDgrada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNoviMenadzer)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID-menadzera:";
			// 
			// nudID
			// 
			this.nudID.Location = new System.Drawing.Point(167, 14);
			this.nudID.Name = "nudID";
			this.nudID.Size = new System.Drawing.Size(141, 20);
			this.nudID.TabIndex = 1;
			this.nudID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.naziv,
            this.IDRegCen,
            this.columnHeader1});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(14, 81);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(294, 214);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// id
			// 
			this.id.Text = "ID";
			this.id.Width = 47;
			// 
			// naziv
			// 
			this.naziv.Text = "Naziv grada";
			this.naziv.Width = 83;
			// 
			// IDRegCen
			// 
			this.IDRegCen.Text = "ID_Reg_C";
			this.IDRegCen.Width = 74;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID_Menadzera";
			this.columnHeader1.Width = 84;
			// 
			// DodajGrad
			// 
			this.DodajGrad.Location = new System.Drawing.Point(314, 307);
			this.DodajGrad.Name = "DodajGrad";
			this.DodajGrad.Size = new System.Drawing.Size(165, 64);
			this.DodajGrad.TabIndex = 4;
			this.DodajGrad.Text = "Dodaj grad";
			this.DodajGrad.UseVisualStyleBackColor = true;
			this.DodajGrad.Click += new System.EventHandler(this.DodajGrad_Click);
			// 
			// tbPrikaziGradovePoMenadzeru
			// 
			this.tbPrikaziGradovePoMenadzeru.Location = new System.Drawing.Point(14, 47);
			this.tbPrikaziGradovePoMenadzeru.Name = "tbPrikaziGradovePoMenadzeru";
			this.tbPrikaziGradovePoMenadzeru.Size = new System.Drawing.Size(125, 28);
			this.tbPrikaziGradovePoMenadzeru.TabIndex = 16;
			this.tbPrikaziGradovePoMenadzeru.Text = "Menadzer pokriva gradove";
			this.tbPrikaziGradovePoMenadzeru.UseVisualStyleBackColor = true;
			this.tbPrikaziGradovePoMenadzeru.Click += new System.EventHandler(this.tbPrikaziGradovePoMenadzeru_Click);
			// 
			// prikaziSveGradove
			// 
			this.prikaziSveGradove.Location = new System.Drawing.Point(167, 47);
			this.prikaziSveGradove.Name = "prikaziSveGradove";
			this.prikaziSveGradove.Size = new System.Drawing.Size(141, 28);
			this.prikaziSveGradove.TabIndex = 17;
			this.prikaziSveGradove.Text = "Prikazi sve gradove";
			this.prikaziSveGradove.UseVisualStyleBackColor = true;
			this.prikaziSveGradove.Click += new System.EventHandler(this.prikaziSveGradove_Click);
			// 
			// btnObrisi
			// 
			this.btnObrisi.Location = new System.Drawing.Point(485, 307);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(138, 64);
			this.btnObrisi.TabIndex = 19;
			this.btnObrisi.Text = "Obrisi grad";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
			// 
			// LBpom
			// 
			this.LBpom.AutoSize = true;
			this.LBpom.Location = new System.Drawing.Point(588, 21);
			this.LBpom.Name = "LBpom";
			this.LBpom.Size = new System.Drawing.Size(28, 13);
			this.LBpom.TabIndex = 28;
			this.LBpom.Text = "Pom";
			this.LBpom.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 315);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Novo ime grada:";
			// 
			// tbNovoIme
			// 
			this.tbNovoIme.Location = new System.Drawing.Point(118, 312);
			this.tbNovoIme.Name = "tbNovoIme";
			this.tbNovoIme.Size = new System.Drawing.Size(190, 20);
			this.tbNovoIme.TabIndex = 22;
			// 
			// btnIzmeniIme
			// 
			this.btnIzmeniIme.Location = new System.Drawing.Point(16, 348);
			this.btnIzmeniIme.Name = "btnIzmeniIme";
			this.btnIzmeniIme.Size = new System.Drawing.Size(292, 23);
			this.btnIzmeniIme.TabIndex = 23;
			this.btnIzmeniIme.Text = "Izmeni ime grada";
			this.btnIzmeniIme.UseVisualStyleBackColor = true;
			this.btnIzmeniIme.Click += new System.EventHandler(this.btnIzmeniIme_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(315, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(164, 26);
			this.label6.TabIndex = 29;
			this.label6.Text = "ID grada prilikom bilo koje izmene\r\nbirati na numericUpDown-u ispod";
			// 
			// nudIDgrada
			// 
			this.nudIDgrada.Location = new System.Drawing.Point(479, 60);
			this.nudIDgrada.Name = "nudIDgrada";
			this.nudIDgrada.Size = new System.Drawing.Size(141, 20);
			this.nudIDgrada.TabIndex = 38;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(325, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 37;
			this.label4.Text = "ID grada:";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.Location = new System.Drawing.Point(328, 257);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(292, 23);
			this.btnIzmeni.TabIndex = 36;
			this.btnIzmeni.Text = "Izmeni menadzera ili regionalni centar";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// nudRC
			// 
			this.nudRC.Enabled = false;
			this.nudRC.Location = new System.Drawing.Point(479, 214);
			this.nudRC.Name = "nudRC";
			this.nudRC.Size = new System.Drawing.Size(141, 20);
			this.nudRC.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(325, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "Novi Reg_C";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(390, 180);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(170, 17);
			this.checkBox2.TabIndex = 33;
			this.checkBox2.Text = "Izmeni  regionalni centar grada";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// nudNoviMenadzer
			// 
			this.nudNoviMenadzer.Enabled = false;
			this.nudNoviMenadzer.Location = new System.Drawing.Point(479, 137);
			this.nudNoviMenadzer.Name = "nudNoviMenadzer";
			this.nudNoviMenadzer.Size = new System.Drawing.Size(141, 20);
			this.nudNoviMenadzer.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(325, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Novi menadzer:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(406, 101);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(141, 17);
			this.checkBox1.TabIndex = 30;
			this.checkBox1.Text = "Izmeni menadzera grada";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// GradForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 390);
			this.Controls.Add(this.nudIDgrada);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnIzmeni);
			this.Controls.Add(this.nudRC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.nudNoviMenadzer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.LBpom);
			this.Controls.Add(this.btnIzmeniIme);
			this.Controls.Add(this.tbNovoIme);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.prikaziSveGradove);
			this.Controls.Add(this.tbPrikaziGradovePoMenadzeru);
			this.Controls.Add(this.DodajGrad);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.nudID);
			this.Controls.Add(this.label1);
			this.Name = "GradForma";
			this.Text = "Grad";
			this.Load += new System.EventHandler(this.GradForma_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudIDgrada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNoviMenadzer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudID;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader naziv;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader IDRegCen;
		private System.Windows.Forms.Button DodajGrad;
		private System.Windows.Forms.Button tbPrikaziGradovePoMenadzeru;
		private System.Windows.Forms.Button prikaziSveGradove;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.Label LBpom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbNovoIme;
		private System.Windows.Forms.Button btnIzmeniIme;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudIDgrada;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.NumericUpDown nudRC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.NumericUpDown nudNoviMenadzer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}