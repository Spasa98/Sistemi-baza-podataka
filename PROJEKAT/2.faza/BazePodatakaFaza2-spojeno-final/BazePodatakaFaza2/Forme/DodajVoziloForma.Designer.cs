
namespace BazePodatakaFaza2.Forme
{
    partial class DodajVozilo
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbRegOznaka = new System.Windows.Forms.TextBox();
			this.tbModel = new System.Windows.Forms.TextBox();
			this.tbProizvodjac = new System.Windows.Forms.TextBox();
			this.tbTip = new System.Windows.Forms.TextBox();
			this.tbBoja = new System.Windows.Forms.TextBox();
			this.nudRegCen = new System.Windows.Forms.NumericUpDown();
			this.btnDodajVozilo = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.idRegCen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.nudRegCen)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registarska oznaka";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Model";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 72);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Proizvodjac";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 105);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tip";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2, 137);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Boja";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 168);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Regionalni centar";
			// 
			// tbRegOznaka
			// 
			this.tbRegOznaka.Location = new System.Drawing.Point(155, 7);
			this.tbRegOznaka.Margin = new System.Windows.Forms.Padding(2);
			this.tbRegOznaka.Name = "tbRegOznaka";
			this.tbRegOznaka.Size = new System.Drawing.Size(91, 20);
			this.tbRegOznaka.TabIndex = 6;
			// 
			// tbModel
			// 
			this.tbModel.Location = new System.Drawing.Point(155, 37);
			this.tbModel.Margin = new System.Windows.Forms.Padding(2);
			this.tbModel.Name = "tbModel";
			this.tbModel.Size = new System.Drawing.Size(91, 20);
			this.tbModel.TabIndex = 7;
			// 
			// tbProizvodjac
			// 
			this.tbProizvodjac.Location = new System.Drawing.Point(155, 69);
			this.tbProizvodjac.Margin = new System.Windows.Forms.Padding(2);
			this.tbProizvodjac.Name = "tbProizvodjac";
			this.tbProizvodjac.Size = new System.Drawing.Size(91, 20);
			this.tbProizvodjac.TabIndex = 8;
			// 
			// tbTip
			// 
			this.tbTip.Location = new System.Drawing.Point(155, 102);
			this.tbTip.Margin = new System.Windows.Forms.Padding(2);
			this.tbTip.Name = "tbTip";
			this.tbTip.Size = new System.Drawing.Size(91, 20);
			this.tbTip.TabIndex = 9;
			// 
			// tbBoja
			// 
			this.tbBoja.Location = new System.Drawing.Point(155, 134);
			this.tbBoja.Margin = new System.Windows.Forms.Padding(2);
			this.tbBoja.Name = "tbBoja";
			this.tbBoja.Size = new System.Drawing.Size(91, 20);
			this.tbBoja.TabIndex = 10;
			// 
			// nudRegCen
			// 
			this.nudRegCen.Location = new System.Drawing.Point(155, 166);
			this.nudRegCen.Margin = new System.Windows.Forms.Padding(2);
			this.nudRegCen.Name = "nudRegCen";
			this.nudRegCen.Size = new System.Drawing.Size(91, 20);
			this.nudRegCen.TabIndex = 11;
			this.nudRegCen.ValueChanged += new System.EventHandler(this.nudRegCen_ValueChanged);
			// 
			// btnDodajVozilo
			// 
			this.btnDodajVozilo.Location = new System.Drawing.Point(91, 204);
			this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(2);
			this.btnDodajVozilo.Name = "btnDodajVozilo";
			this.btnDodajVozilo.Size = new System.Drawing.Size(88, 25);
			this.btnDodajVozilo.TabIndex = 12;
			this.btnDodajVozilo.Text = "Dodaj Vozilo";
			this.btnDodajVozilo.UseVisualStyleBackColor = true;
			this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listView1);
			this.panel1.Location = new System.Drawing.Point(287, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(149, 244);
			this.panel1.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.tbRegOznaka);
			this.panel2.Controls.Add(this.btnDodajVozilo);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.nudRegCen);
			this.panel2.Controls.Add(this.tbModel);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.tbBoja);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.tbTip);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.tbProizvodjac);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(269, 244);
			this.panel2.TabIndex = 14;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRegCen});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(3, 7);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(141, 234);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// idRegCen
			// 
			this.idRegCen.Text = "ID-jevi regionalnih centara";
			this.idRegCen.Width = 142;
			// 
			// DodajVozilo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(442, 260);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "DodajVozilo";
			this.Text = "Dodaj Vozilo";
			this.Load += new System.EventHandler(this.DodajVoziloForma_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudRegCen)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRegOznaka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbProizvodjac;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.TextBox tbBoja;
        private System.Windows.Forms.NumericUpDown nudRegCen;
        private System.Windows.Forms.Button btnDodajVozilo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader idRegCen;
	}
}