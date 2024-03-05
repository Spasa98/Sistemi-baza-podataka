
namespace BazePodatakaFaza2
{
    partial class Obezbedjenje
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
            this.cmdUcitajZaposlenog = new System.Windows.Forms.Button();
            this.cmdUcitajTehnickoLice = new System.Windows.Forms.Button();
            this.cmdMenadzerPokrivaGrad = new System.Windows.Forms.Button();
            this.cmdGradoviObuhvaceniRegCentar = new System.Windows.Forms.Button();
            this.cmdObjekatImaAlarmniSistem = new System.Windows.Forms.Button();
            this.cmdUcitajMenadzera = new System.Windows.Forms.Button();
            this.cmdUcitajObjekte = new System.Windows.Forms.Button();
            this.cmdIzmeniTelefonO = new System.Windows.Forms.Button();
            this.cmdDodajVozilo = new System.Windows.Forms.Button();
            this.cmdUcitajVozila = new System.Windows.Forms.Button();
            this.cmdUcitajGradove = new System.Windows.Forms.Button();
            this.cmdDodajObjekat = new System.Windows.Forms.Button();
            this.cmdLINQVozilo = new System.Windows.Forms.Button();
            this.cmdObrisiTelefonO = new System.Windows.Forms.Button();
            this.cmdEkipaDuziVozilo = new System.Windows.Forms.Button();
            this.cmdEkipaInterveniseObj = new System.Windows.Forms.Button();
            this.cmdLINQTehnickoLice = new System.Windows.Forms.Button();
            this.cmdNativeSql = new System.Windows.Forms.Button();
            this.cmdUcitajAS = new System.Windows.Forms.Button();
            this.cmdRefreshGrad = new System.Windows.Forms.Button();
            this.cmdDodajGrad = new System.Windows.Forms.Button();
            this.cmdDodajTehLice = new System.Windows.Forms.Button();
            this.cmdDodajMenadzera = new System.Windows.Forms.Button();
            this.cmdObrisiTehLice = new System.Windows.Forms.Button();
            this.cmdIntervencijeObjektiEkipe = new System.Windows.Forms.Button();
            this.MenadzerGrad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitajZaposlenog
            // 
            this.cmdUcitajZaposlenog.Location = new System.Drawing.Point(12, 12);
            this.cmdUcitajZaposlenog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajZaposlenog.Name = "cmdUcitajZaposlenog";
            this.cmdUcitajZaposlenog.Size = new System.Drawing.Size(233, 31);
            this.cmdUcitajZaposlenog.TabIndex = 0;
            this.cmdUcitajZaposlenog.Text = "Ucitaj Zaposlenog";
            this.cmdUcitajZaposlenog.UseVisualStyleBackColor = true;
            this.cmdUcitajZaposlenog.Click += new System.EventHandler(this.cmdUcitajZaposlenog_Click);
            // 
            // cmdUcitajTehnickoLice
            // 
            this.cmdUcitajTehnickoLice.Location = new System.Drawing.Point(252, 12);
            this.cmdUcitajTehnickoLice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajTehnickoLice.Name = "cmdUcitajTehnickoLice";
            this.cmdUcitajTehnickoLice.Size = new System.Drawing.Size(233, 32);
            this.cmdUcitajTehnickoLice.TabIndex = 1;
            this.cmdUcitajTehnickoLice.Text = "Ucitaj Tehnicko Lice";
            this.cmdUcitajTehnickoLice.UseVisualStyleBackColor = true;
            this.cmdUcitajTehnickoLice.Click += new System.EventHandler(this.cmdUcitajTehnickoLice_Click);
            // 
            // cmdMenadzerPokrivaGrad
            // 
            this.cmdMenadzerPokrivaGrad.Location = new System.Drawing.Point(148, 172);
            this.cmdMenadzerPokrivaGrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMenadzerPokrivaGrad.Name = "cmdMenadzerPokrivaGrad";
            this.cmdMenadzerPokrivaGrad.Size = new System.Drawing.Size(417, 31);
            this.cmdMenadzerPokrivaGrad.TabIndex = 2;
            this.cmdMenadzerPokrivaGrad.Text = "Koji Menadzer pokriva koji Grad (1:N)";
            this.cmdMenadzerPokrivaGrad.UseVisualStyleBackColor = true;
            this.cmdMenadzerPokrivaGrad.Click += new System.EventHandler(this.cmdMenadzerPokrivaGrad_Click);
            // 
            // cmdGradoviObuhvaceniRegCentar
            // 
            this.cmdGradoviObuhvaceniRegCentar.Location = new System.Drawing.Point(148, 207);
            this.cmdGradoviObuhvaceniRegCentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGradoviObuhvaceniRegCentar.Name = "cmdGradoviObuhvaceniRegCentar";
            this.cmdGradoviObuhvaceniRegCentar.Size = new System.Drawing.Size(417, 31);
            this.cmdGradoviObuhvaceniRegCentar.TabIndex = 3;
            this.cmdGradoviObuhvaceniRegCentar.Text = "Koji Gradovi su obuhvaceni kojim Regionalnim Centrom (N:1)\r\n";
            this.cmdGradoviObuhvaceniRegCentar.UseVisualStyleBackColor = true;
            this.cmdGradoviObuhvaceniRegCentar.Click += new System.EventHandler(this.cmdGradoviObuhvaceniRegCentar_Click);
            // 
            // cmdObjekatImaAlarmniSistem
            // 
            this.cmdObjekatImaAlarmniSistem.Location = new System.Drawing.Point(148, 242);
            this.cmdObjekatImaAlarmniSistem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdObjekatImaAlarmniSistem.Name = "cmdObjekatImaAlarmniSistem";
            this.cmdObjekatImaAlarmniSistem.Size = new System.Drawing.Size(418, 31);
            this.cmdObjekatImaAlarmniSistem.TabIndex = 5;
            this.cmdObjekatImaAlarmniSistem.Text = "U kom Objektu postoji koji Alarmni Sistem (1:1)";
            this.cmdObjekatImaAlarmniSistem.UseVisualStyleBackColor = true;
            this.cmdObjekatImaAlarmniSistem.Click += new System.EventHandler(this.cmdObjekatImaAlarmniSistem_Click);
            // 
            // cmdUcitajMenadzera
            // 
            this.cmdUcitajMenadzera.Location = new System.Drawing.Point(491, 13);
            this.cmdUcitajMenadzera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajMenadzera.Name = "cmdUcitajMenadzera";
            this.cmdUcitajMenadzera.Size = new System.Drawing.Size(233, 31);
            this.cmdUcitajMenadzera.TabIndex = 6;
            this.cmdUcitajMenadzera.Text = "Ucitaj Menadzera";
            this.cmdUcitajMenadzera.UseVisualStyleBackColor = true;
            this.cmdUcitajMenadzera.Click += new System.EventHandler(this.cmdUcitajMenadzera_Click);
            // 
            // cmdUcitajObjekte
            // 
            this.cmdUcitajObjekte.Location = new System.Drawing.Point(12, 133);
            this.cmdUcitajObjekte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajObjekte.Name = "cmdUcitajObjekte";
            this.cmdUcitajObjekte.Size = new System.Drawing.Size(233, 30);
            this.cmdUcitajObjekte.TabIndex = 11;
            this.cmdUcitajObjekte.Text = "Ucitaj Objekte";
            this.cmdUcitajObjekte.UseVisualStyleBackColor = true;
            this.cmdUcitajObjekte.Click += new System.EventHandler(this.cmdUcitajObjekte_Click);
            // 
            // cmdIzmeniTelefonO
            // 
            this.cmdIzmeniTelefonO.Location = new System.Drawing.Point(148, 352);
            this.cmdIzmeniTelefonO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdIzmeniTelefonO.Name = "cmdIzmeniTelefonO";
            this.cmdIzmeniTelefonO.Size = new System.Drawing.Size(417, 30);
            this.cmdIzmeniTelefonO.TabIndex = 15;
            this.cmdIzmeniTelefonO.Text = "Izmeni/Dodaj Telefon Objekta";
            this.cmdIzmeniTelefonO.UseVisualStyleBackColor = true;
            this.cmdIzmeniTelefonO.Click += new System.EventHandler(this.cmdIzmeniTelefonO_Click);
            // 
            // cmdDodajVozilo
            // 
            this.cmdDodajVozilo.Location = new System.Drawing.Point(491, 94);
            this.cmdDodajVozilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDodajVozilo.Name = "cmdDodajVozilo";
            this.cmdDodajVozilo.Size = new System.Drawing.Size(233, 30);
            this.cmdDodajVozilo.TabIndex = 16;
            this.cmdDodajVozilo.Text = "Dodaj Vozilo";
            this.cmdDodajVozilo.UseVisualStyleBackColor = true;
            this.cmdDodajVozilo.Click += new System.EventHandler(this.cmdDodajVozilo_Click);
            // 
            // cmdUcitajVozila
            // 
            this.cmdUcitajVozila.Location = new System.Drawing.Point(251, 133);
            this.cmdUcitajVozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajVozila.Name = "cmdUcitajVozila";
            this.cmdUcitajVozila.Size = new System.Drawing.Size(233, 30);
            this.cmdUcitajVozila.TabIndex = 17;
            this.cmdUcitajVozila.Text = "Ucitaj Vozila";
            this.cmdUcitajVozila.UseVisualStyleBackColor = true;
            this.cmdUcitajVozila.Click += new System.EventHandler(this.cmdUcitajVozila_Click);
            // 
            // cmdUcitajGradove
            // 
            this.cmdUcitajGradove.Location = new System.Drawing.Point(12, 94);
            this.cmdUcitajGradove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajGradove.Name = "cmdUcitajGradove";
            this.cmdUcitajGradove.Size = new System.Drawing.Size(233, 30);
            this.cmdUcitajGradove.TabIndex = 18;
            this.cmdUcitajGradove.Text = "Ucitaj Gradove";
            this.cmdUcitajGradove.UseVisualStyleBackColor = true;
            this.cmdUcitajGradove.Click += new System.EventHandler(this.cmdUcitajGradove_Click);
            // 
            // cmdDodajObjekat
            // 
            this.cmdDodajObjekat.Location = new System.Drawing.Point(252, 94);
            this.cmdDodajObjekat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDodajObjekat.Name = "cmdDodajObjekat";
            this.cmdDodajObjekat.Size = new System.Drawing.Size(233, 30);
            this.cmdDodajObjekat.TabIndex = 19;
            this.cmdDodajObjekat.Text = "Dodaj Objekat";
            this.cmdDodajObjekat.UseVisualStyleBackColor = true;
            this.cmdDodajObjekat.Click += new System.EventHandler(this.cmdDodajObjekat_Click);
            // 
            // cmdLINQVozilo
            // 
            this.cmdLINQVozilo.Location = new System.Drawing.Point(375, 529);
            this.cmdLINQVozilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLINQVozilo.Name = "cmdLINQVozilo";
            this.cmdLINQVozilo.Size = new System.Drawing.Size(349, 30);
            this.cmdLINQVozilo.TabIndex = 21;
            this.cmdLINQVozilo.Text = "LINQ Vozilo";
            this.cmdLINQVozilo.UseVisualStyleBackColor = true;
            this.cmdLINQVozilo.Click += new System.EventHandler(this.cmdLINQVozilo_Click);
            // 
            // cmdObrisiTelefonO
            // 
            this.cmdObrisiTelefonO.Location = new System.Drawing.Point(148, 386);
            this.cmdObrisiTelefonO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdObrisiTelefonO.Name = "cmdObrisiTelefonO";
            this.cmdObrisiTelefonO.Size = new System.Drawing.Size(417, 30);
            this.cmdObrisiTelefonO.TabIndex = 22;
            this.cmdObrisiTelefonO.Text = "Obrisi Telefon Objekta";
            this.cmdObrisiTelefonO.UseVisualStyleBackColor = true;
            this.cmdObrisiTelefonO.Click += new System.EventHandler(this.cmdObrisiTelefonO_Click);
            // 
            // cmdEkipaDuziVozilo
            // 
            this.cmdEkipaDuziVozilo.Location = new System.Drawing.Point(148, 454);
            this.cmdEkipaDuziVozilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdEkipaDuziVozilo.Name = "cmdEkipaDuziVozilo";
            this.cmdEkipaDuziVozilo.Size = new System.Drawing.Size(417, 31);
            this.cmdEkipaDuziVozilo.TabIndex = 26;
            this.cmdEkipaDuziVozilo.Text = "Kreiraj Ekipa duzi Vozilo";
            this.cmdEkipaDuziVozilo.UseVisualStyleBackColor = true;
            this.cmdEkipaDuziVozilo.Click += new System.EventHandler(this.cmdEkipaDuziVozilo_Click);
            // 
            // cmdEkipaInterveniseObj
            // 
            this.cmdEkipaInterveniseObj.Location = new System.Drawing.Point(148, 489);
            this.cmdEkipaInterveniseObj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdEkipaInterveniseObj.Name = "cmdEkipaInterveniseObj";
            this.cmdEkipaInterveniseObj.Size = new System.Drawing.Size(417, 32);
            this.cmdEkipaInterveniseObj.TabIndex = 30;
            this.cmdEkipaInterveniseObj.Text = "Kreiraj Ekipa intervenise Objekat";
            this.cmdEkipaInterveniseObj.UseVisualStyleBackColor = true;
            this.cmdEkipaInterveniseObj.Click += new System.EventHandler(this.cmdEkipaInterveniseObj_Click);
            // 
            // cmdLINQTehnickoLice
            // 
            this.cmdLINQTehnickoLice.Location = new System.Drawing.Point(12, 529);
            this.cmdLINQTehnickoLice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLINQTehnickoLice.Name = "cmdLINQTehnickoLice";
            this.cmdLINQTehnickoLice.Size = new System.Drawing.Size(352, 30);
            this.cmdLINQTehnickoLice.TabIndex = 32;
            this.cmdLINQTehnickoLice.Text = "LINQ Tehnicko Lice";
            this.cmdLINQTehnickoLice.UseVisualStyleBackColor = true;
            this.cmdLINQTehnickoLice.Click += new System.EventHandler(this.cmdLINQTehnickoLice_Click);
            // 
            // cmdNativeSql
            // 
            this.cmdNativeSql.Location = new System.Drawing.Point(12, 563);
            this.cmdNativeSql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdNativeSql.Name = "cmdNativeSql";
            this.cmdNativeSql.Size = new System.Drawing.Size(352, 31);
            this.cmdNativeSql.TabIndex = 33;
            this.cmdNativeSql.Text = "Native SQL";
            this.cmdNativeSql.UseVisualStyleBackColor = true;
            this.cmdNativeSql.Click += new System.EventHandler(this.cmdNativeSql_Click);
            // 
            // cmdUcitajAS
            // 
            this.cmdUcitajAS.Location = new System.Drawing.Point(491, 133);
            this.cmdUcitajAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUcitajAS.Name = "cmdUcitajAS";
            this.cmdUcitajAS.Size = new System.Drawing.Size(233, 30);
            this.cmdUcitajAS.TabIndex = 34;
            this.cmdUcitajAS.Text = "Ucitaj Alarmne Sisteme";
            this.cmdUcitajAS.UseVisualStyleBackColor = true;
            this.cmdUcitajAS.Click += new System.EventHandler(this.cmdUcitajAS_Click);
            // 
            // cmdRefreshGrad
            // 
            this.cmdRefreshGrad.Location = new System.Drawing.Point(375, 563);
            this.cmdRefreshGrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRefreshGrad.Name = "cmdRefreshGrad";
            this.cmdRefreshGrad.Size = new System.Drawing.Size(349, 30);
            this.cmdRefreshGrad.TabIndex = 35;
            this.cmdRefreshGrad.Text = "Refresh Grad";
            this.cmdRefreshGrad.UseVisualStyleBackColor = true;
            this.cmdRefreshGrad.Click += new System.EventHandler(this.cmdRefreshGrad_Click);
            // 
            // cmdDodajGrad
            // 
            this.cmdDodajGrad.Location = new System.Drawing.Point(491, 53);
            this.cmdDodajGrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDodajGrad.Name = "cmdDodajGrad";
            this.cmdDodajGrad.Size = new System.Drawing.Size(233, 31);
            this.cmdDodajGrad.TabIndex = 36;
            this.cmdDodajGrad.Text = "Dodaj Grad";
            this.cmdDodajGrad.UseVisualStyleBackColor = true;
            this.cmdDodajGrad.Click += new System.EventHandler(this.cmdDodajGrad_Click);
            // 
            // cmdDodajTehLice
            // 
            this.cmdDodajTehLice.Location = new System.Drawing.Point(12, 53);
            this.cmdDodajTehLice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDodajTehLice.Name = "cmdDodajTehLice";
            this.cmdDodajTehLice.Size = new System.Drawing.Size(233, 31);
            this.cmdDodajTehLice.TabIndex = 38;
            this.cmdDodajTehLice.Text = "Dodaj Tehnicko Lice";
            this.cmdDodajTehLice.UseVisualStyleBackColor = true;
            this.cmdDodajTehLice.Click += new System.EventHandler(this.cmdDodajTehLice_Click);
            // 
            // cmdDodajMenadzera
            // 
            this.cmdDodajMenadzera.Location = new System.Drawing.Point(252, 54);
            this.cmdDodajMenadzera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDodajMenadzera.Name = "cmdDodajMenadzera";
            this.cmdDodajMenadzera.Size = new System.Drawing.Size(233, 30);
            this.cmdDodajMenadzera.TabIndex = 39;
            this.cmdDodajMenadzera.Text = "Dodaj Menadzera";
            this.cmdDodajMenadzera.UseVisualStyleBackColor = true;
            this.cmdDodajMenadzera.Click += new System.EventHandler(this.cmdDodajMenadzera_Click);
            // 
            // cmdObrisiTehLice
            // 
            this.cmdObrisiTehLice.Location = new System.Drawing.Point(148, 420);
            this.cmdObrisiTehLice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdObrisiTehLice.Name = "cmdObrisiTehLice";
            this.cmdObrisiTehLice.Size = new System.Drawing.Size(417, 30);
            this.cmdObrisiTehLice.TabIndex = 40;
            this.cmdObrisiTehLice.Text = "Obrisi Tehnicko Lice";
            this.cmdObrisiTehLice.UseVisualStyleBackColor = true;
            this.cmdObrisiTehLice.Click += new System.EventHandler(this.cmdObrisiTehLice_Click);
            // 
            // cmdIntervencijeObjektiEkipe
            // 
            this.cmdIntervencijeObjektiEkipe.Location = new System.Drawing.Point(148, 277);
            this.cmdIntervencijeObjektiEkipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdIntervencijeObjektiEkipe.Name = "cmdIntervencijeObjektiEkipe";
            this.cmdIntervencijeObjektiEkipe.Size = new System.Drawing.Size(417, 32);
            this.cmdIntervencijeObjektiEkipe.TabIndex = 41;
            this.cmdIntervencijeObjektiEkipe.Text = "Lista svih Intervencija na Objektima sa Ekipama (M:N)";
            this.cmdIntervencijeObjektiEkipe.UseVisualStyleBackColor = true;
            this.cmdIntervencijeObjektiEkipe.Click += new System.EventHandler(this.cmdIntervencijeObjektiEkipe_Click);
            // 
            // MenadzerGrad
            // 
            this.MenadzerGrad.Location = new System.Drawing.Point(148, 315);
            this.MenadzerGrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenadzerGrad.Name = "MenadzerGrad";
            this.MenadzerGrad.Size = new System.Drawing.Size(417, 31);
            this.MenadzerGrad.TabIndex = 42;
            this.MenadzerGrad.Text = "Grad Forma (dodaj, izmeni, obrisi, ucitaj)";
            this.MenadzerGrad.UseVisualStyleBackColor = true;
            this.MenadzerGrad.Click += new System.EventHandler(this.MenadzerGrad_Click);
            // 
            // Obezbedjenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 605);
            this.Controls.Add(this.MenadzerGrad);
            this.Controls.Add(this.cmdIntervencijeObjektiEkipe);
            this.Controls.Add(this.cmdObrisiTehLice);
            this.Controls.Add(this.cmdDodajMenadzera);
            this.Controls.Add(this.cmdDodajTehLice);
            this.Controls.Add(this.cmdDodajGrad);
            this.Controls.Add(this.cmdRefreshGrad);
            this.Controls.Add(this.cmdUcitajAS);
            this.Controls.Add(this.cmdNativeSql);
            this.Controls.Add(this.cmdLINQTehnickoLice);
            this.Controls.Add(this.cmdEkipaInterveniseObj);
            this.Controls.Add(this.cmdEkipaDuziVozilo);
            this.Controls.Add(this.cmdObrisiTelefonO);
            this.Controls.Add(this.cmdLINQVozilo);
            this.Controls.Add(this.cmdDodajObjekat);
            this.Controls.Add(this.cmdUcitajGradove);
            this.Controls.Add(this.cmdUcitajVozila);
            this.Controls.Add(this.cmdDodajVozilo);
            this.Controls.Add(this.cmdIzmeniTelefonO);
            this.Controls.Add(this.cmdUcitajObjekte);
            this.Controls.Add(this.cmdUcitajMenadzera);
            this.Controls.Add(this.cmdObjekatImaAlarmniSistem);
            this.Controls.Add(this.cmdGradoviObuhvaceniRegCentar);
            this.Controls.Add(this.cmdMenadzerPokrivaGrad);
            this.Controls.Add(this.cmdUcitajTehnickoLice);
            this.Controls.Add(this.cmdUcitajZaposlenog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Obezbedjenje";
            this.Text = "Obezbedjenje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitajZaposlenog;
        private System.Windows.Forms.Button cmdUcitajTehnickoLice;
        private System.Windows.Forms.Button cmdMenadzerPokrivaGrad;
        private System.Windows.Forms.Button cmdGradoviObuhvaceniRegCentar;
        private System.Windows.Forms.Button cmdObjekatImaAlarmniSistem;
        private System.Windows.Forms.Button cmdUcitajMenadzera;
        private System.Windows.Forms.Button cmdUcitajObjekte;
        private System.Windows.Forms.Button cmdIzmeniTelefonO;
        private System.Windows.Forms.Button cmdDodajVozilo;
        private System.Windows.Forms.Button cmdUcitajVozila;
        private System.Windows.Forms.Button cmdUcitajGradove;
        private System.Windows.Forms.Button cmdDodajObjekat;
        private System.Windows.Forms.Button cmdLINQVozilo;
        private System.Windows.Forms.Button cmdObrisiTelefonO;
        private System.Windows.Forms.Button cmdEkipaDuziVozilo;
        private System.Windows.Forms.Button cmdEkipaInterveniseObj;
        private System.Windows.Forms.Button cmdLINQTehnickoLice;
        private System.Windows.Forms.Button cmdNativeSql;
        private System.Windows.Forms.Button cmdUcitajAS;
        private System.Windows.Forms.Button cmdRefreshGrad;
        private System.Windows.Forms.Button cmdDodajGrad;
        private System.Windows.Forms.Button cmdDodajTehLice;
        private System.Windows.Forms.Button cmdDodajMenadzera;
        private System.Windows.Forms.Button cmdObrisiTehLice;
        private System.Windows.Forms.Button cmdIntervencijeObjektiEkipe;
		private System.Windows.Forms.Button MenadzerGrad;
	}
}

