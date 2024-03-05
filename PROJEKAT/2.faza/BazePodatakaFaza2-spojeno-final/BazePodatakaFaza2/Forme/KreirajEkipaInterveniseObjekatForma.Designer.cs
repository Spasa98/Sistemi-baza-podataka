
namespace BazePodatakaFaza2.Forme
{
    partial class KreirajEkipaInterveniseObjekatForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbObjekat = new System.Windows.Forms.ComboBox();
            this.cbEkipa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbVreme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kreiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbObjekat
            // 
            this.cbObjekat.FormattingEnabled = true;
            this.cbObjekat.Location = new System.Drawing.Point(239, 101);
            this.cbObjekat.Name = "cbObjekat";
            this.cbObjekat.Size = new System.Drawing.Size(141, 24);
            this.cbObjekat.TabIndex = 8;
            // 
            // cbEkipa
            // 
            this.cbEkipa.FormattingEnabled = true;
            this.cbEkipa.Location = new System.Drawing.Point(239, 34);
            this.cbEkipa.Name = "cbEkipa";
            this.cbEkipa.Size = new System.Drawing.Size(141, 24);
            this.cbEkipa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Objekat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ekipa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vreme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opis";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(239, 167);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(141, 22);
            this.date.TabIndex = 13;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(239, 295);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(141, 22);
            this.tbOpis.TabIndex = 14;
            // 
            // tbVreme
            // 
            this.tbVreme.Location = new System.Drawing.Point(239, 235);
            this.tbVreme.Name = "tbVreme";
            this.tbVreme.Size = new System.Drawing.Size(141, 22);
            this.tbVreme.TabIndex = 15;
            // 
            // KreirajEkipaInterveniseObjekatForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 424);
            this.Controls.Add(this.tbVreme);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbObjekat);
            this.Controls.Add(this.cbEkipa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KreirajEkipaInterveniseObjekatForma";
            this.Text = "Kreiraj Ekipa Intervenise Objekat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbObjekat;
        private System.Windows.Forms.ComboBox cbEkipa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbVreme;
    }
}