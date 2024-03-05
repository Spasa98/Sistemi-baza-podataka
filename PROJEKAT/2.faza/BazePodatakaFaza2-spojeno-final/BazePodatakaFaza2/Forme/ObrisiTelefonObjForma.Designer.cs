
namespace BazePodatakaFaza2.Forme
{
    partial class ObrisiTelefonObjForma
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
			this.btnObrisi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnObrisi
			// 
			this.btnObrisi.Location = new System.Drawing.Point(85, 117);
			this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(143, 24);
			this.btnObrisi.TabIndex = 17;
			this.btnObrisi.Text = "Obrisi telefon objekta";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Telefon";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(142, 18);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(109, 21);
			this.comboBox1.TabIndex = 14;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(66, 24);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Objekat";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(142, 61);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(109, 21);
			this.comboBox2.TabIndex = 18;
			// 
			// ObrisiTelefonObjForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 151);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.btnObrisi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ObrisiTelefonObjForma";
			this.Text = "Obrisi Telefon Objekta";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}