
namespace BazePodatakaFaza2.Forme
{
    partial class DodajGradForma
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.nudRegCentar = new System.Windows.Forms.NumericUpDown();
            this.tb_imegrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegCentar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(391, 26);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 69);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // nudRegCentar
            // 
            this.nudRegCentar.Location = new System.Drawing.Point(195, 71);
            this.nudRegCentar.Margin = new System.Windows.Forms.Padding(4);
            this.nudRegCentar.Name = "nudRegCentar";
            this.nudRegCentar.Size = new System.Drawing.Size(160, 22);
            this.nudRegCentar.TabIndex = 8;
            // 
            // tb_imegrada
            // 
            this.tb_imegrada.Location = new System.Drawing.Point(195, 26);
            this.tb_imegrada.Margin = new System.Windows.Forms.Padding(4);
            this.tb_imegrada.Name = "tb_imegrada";
            this.tb_imegrada.Size = new System.Drawing.Size(159, 22);
            this.tb_imegrada.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Regionalni centar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime grada:";
            // 
            // DodajGradForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 129);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.nudRegCentar);
            this.Controls.Add(this.tb_imegrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajGradForma";
            this.Text = "Dodaj Grad";
            ((System.ComponentModel.ISupportInitialize)(this.nudRegCentar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown nudRegCentar;
        private System.Windows.Forms.TextBox tb_imegrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}