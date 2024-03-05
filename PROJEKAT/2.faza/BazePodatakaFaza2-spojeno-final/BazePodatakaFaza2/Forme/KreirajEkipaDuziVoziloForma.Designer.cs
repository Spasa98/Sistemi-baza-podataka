
namespace BazePodatakaFaza2.Forme
{
    partial class KreirajEkipaDuziVoziloForma
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
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.cbEkipa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.duziOd = new System.Windows.Forms.DateTimePicker();
            this.duziDo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(255, 96);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(141, 24);
            this.cbVozilo.TabIndex = 8;
            // 
            // cbEkipa
            // 
            this.cbEkipa.FormattingEnabled = true;
            this.cbEkipa.Location = new System.Drawing.Point(256, 29);
            this.cbEkipa.Name = "cbEkipa";
            this.cbEkipa.Size = new System.Drawing.Size(141, 24);
            this.cbEkipa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vozilo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ekipa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duzi od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Duzi do";
            // 
            // duziOd
            // 
            this.duziOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duziOd.Location = new System.Drawing.Point(255, 162);
            this.duziOd.Name = "duziOd";
            this.duziOd.Size = new System.Drawing.Size(142, 22);
            this.duziOd.TabIndex = 12;
            // 
            // duziDo
            // 
            this.duziDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duziDo.Location = new System.Drawing.Point(254, 224);
            this.duziDo.Name = "duziDo";
            this.duziDo.Size = new System.Drawing.Size(142, 22);
            this.duziDo.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kreiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KreirajEkipaDuziVoziloForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.duziDo);
            this.Controls.Add(this.duziOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVozilo);
            this.Controls.Add(this.cbEkipa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KreirajEkipaDuziVoziloForma";
            this.Text = "Kreiraj Ekipa Duzi Vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.ComboBox cbEkipa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker duziOd;
        private System.Windows.Forms.DateTimePicker duziDo;
        private System.Windows.Forms.Button button1;
    }
}