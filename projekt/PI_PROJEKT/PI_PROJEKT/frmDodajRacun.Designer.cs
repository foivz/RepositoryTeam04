namespace PI_PROJEKT
{
    partial class frmDodajRacun
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtIDkorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajRačun = new System.Windows.Forms.Button();
            this.dgvNoveStavke = new System.Windows.Forms.DataGridView();
            this.ID_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popust_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.txtIzabranaStavka = new System.Windows.Forms.TextBox();
            this.btnOdabirStavke = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtIdStavke = new System.Windows.Forms.TextBox();
            this.txtImePrezKupac = new System.Windows.Forms.TextBox();
            this.txtAdresaKupac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOIBKupac = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImeKorisnik = new System.Windows.Forms.TextBox();
            this.txtPrezimeKorisnik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoveStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(97, 71);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(207, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // txtIDkorisnik
            // 
            this.txtIDkorisnik.Location = new System.Drawing.Point(97, 19);
            this.txtIDkorisnik.Name = "txtIDkorisnik";
            this.txtIDkorisnik.ReadOnly = true;
            this.txtIDkorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtIDkorisnik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID korisnik";
            // 
            // btnDodajRačun
            // 
            this.btnDodajRačun.Location = new System.Drawing.Point(491, 463);
            this.btnDodajRačun.Name = "btnDodajRačun";
            this.btnDodajRačun.Size = new System.Drawing.Size(162, 23);
            this.btnDodajRačun.TabIndex = 4;
            this.btnDodajRačun.Text = "Dodaj račun";
            this.btnDodajRačun.UseVisualStyleBackColor = true;
            this.btnDodajRačun.Click += new System.EventHandler(this.btnDodajRačun_Click);
            // 
            // dgvNoveStavke
            // 
            this.dgvNoveStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoveStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_stavke,
            this.naziv_stavke,
            this.jedCijena,
            this.kolicina_stavke,
            this.popust_stavke});
            this.dgvNoveStavke.Location = new System.Drawing.Point(18, 259);
            this.dgvNoveStavke.Name = "dgvNoveStavke";
            this.dgvNoveStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoveStavke.Size = new System.Drawing.Size(647, 169);
            this.dgvNoveStavke.TabIndex = 5;
            this.dgvNoveStavke.SelectionChanged += new System.EventHandler(this.dgvNoveStavke_SelectionChanged);
            // 
            // ID_stavke
            // 
            this.ID_stavke.HeaderText = "ID stavke";
            this.ID_stavke.Name = "ID_stavke";
            this.ID_stavke.ReadOnly = true;
            // 
            // naziv_stavke
            // 
            this.naziv_stavke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv_stavke.HeaderText = "Naziv stavke";
            this.naziv_stavke.Name = "naziv_stavke";
            this.naziv_stavke.ReadOnly = true;
            // 
            // jedCijena
            // 
            this.jedCijena.HeaderText = "Cijena";
            this.jedCijena.Name = "jedCijena";
            // 
            // kolicina_stavke
            // 
            this.kolicina_stavke.HeaderText = "Količina";
            this.kolicina_stavke.Name = "kolicina_stavke";
            this.kolicina_stavke.ReadOnly = true;
            // 
            // popust_stavke
            // 
            this.popust_stavke.HeaderText = "Popust";
            this.popust_stavke.Name = "popust_stavke";
            this.popust_stavke.ReadOnly = true;
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.Location = new System.Drawing.Point(401, 83);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(234, 39);
            this.btnDodajStavke.TabIndex = 6;
            this.btnDodajStavke.Text = "Dodaj stavku";
            this.btnDodajStavke.UseVisualStyleBackColor = true;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Enabled = false;
            this.btnObrisiStavku.Location = new System.Drawing.Point(578, 434);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStavku.TabIndex = 7;
            this.btnObrisiStavku.Text = "Obriši";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnUrediStavku
            // 
            this.btnUrediStavku.Enabled = false;
            this.btnUrediStavku.Location = new System.Drawing.Point(491, 434);
            this.btnUrediStavku.Name = "btnUrediStavku";
            this.btnUrediStavku.Size = new System.Drawing.Size(75, 23);
            this.btnUrediStavku.TabIndex = 8;
            this.btnUrediStavku.Text = "Uredi";
            this.btnUrediStavku.UseVisualStyleBackColor = true;
            this.btnUrediStavku.Click += new System.EventHandler(this.btnUrediStavku_Click);
            // 
            // txtIzabranaStavka
            // 
            this.txtIzabranaStavka.Location = new System.Drawing.Point(69, 19);
            this.txtIzabranaStavka.Name = "txtIzabranaStavka";
            this.txtIzabranaStavka.ReadOnly = true;
            this.txtIzabranaStavka.Size = new System.Drawing.Size(257, 20);
            this.txtIzabranaStavka.TabIndex = 9;
            // 
            // btnOdabirStavke
            // 
            this.btnOdabirStavke.Location = new System.Drawing.Point(332, 17);
            this.btnOdabirStavke.Name = "btnOdabirStavke";
            this.btnOdabirStavke.Size = new System.Drawing.Size(33, 23);
            this.btnOdabirStavke.TabIndex = 10;
            this.btnOdabirStavke.Text = "...";
            this.btnOdabirStavke.UseVisualStyleBackColor = true;
            this.btnOdabirStavke.Click += new System.EventHandler(this.btnOdabirStavke_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(69, 54);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(257, 20);
            this.txtKolicina.TabIndex = 11;
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(224, 80);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(102, 20);
            this.txtPopust.TabIndex = 12;
            this.txtPopust.TextChanged += new System.EventHandler(this.txtPopust_TextChanged);
            this.txtPopust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPopust_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Količina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Popust";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.txtIdStavke);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPopust);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.btnOdabirStavke);
            this.groupBox1.Controls.Add(this.btnDodajStavke);
            this.groupBox1.Controls.Add(this.txtIzabranaStavka);
            this.groupBox1.Location = new System.Drawing.Point(18, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje stavki";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(69, 80);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(84, 20);
            this.txtCijena.TabIndex = 16;
            // 
            // txtIdStavke
            // 
            this.txtIdStavke.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdStavke.Location = new System.Drawing.Point(13, 19);
            this.txtIdStavke.Name = "txtIdStavke";
            this.txtIdStavke.ReadOnly = true;
            this.txtIdStavke.Size = new System.Drawing.Size(50, 20);
            this.txtIdStavke.TabIndex = 15;
            // 
            // txtImePrezKupac
            // 
            this.txtImePrezKupac.Location = new System.Drawing.Point(120, 19);
            this.txtImePrezKupac.Name = "txtImePrezKupac";
            this.txtImePrezKupac.Size = new System.Drawing.Size(159, 20);
            this.txtImePrezKupac.TabIndex = 16;
            // 
            // txtAdresaKupac
            // 
            this.txtAdresaKupac.Location = new System.Drawing.Point(120, 45);
            this.txtAdresaKupac.Name = "txtAdresaKupac";
            this.txtAdresaKupac.Size = new System.Drawing.Size(159, 20);
            this.txtAdresaKupac.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ime i prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "OIB";
            // 
            // txtOIBKupac
            // 
            this.txtOIBKupac.Location = new System.Drawing.Point(120, 72);
            this.txtOIBKupac.MaxLength = 11;
            this.txtOIBKupac.Name = "txtOIBKupac";
            this.txtOIBKupac.Size = new System.Drawing.Size(159, 20);
            this.txtOIBKupac.TabIndex = 21;
            this.txtOIBKupac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOIBKupac_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOIBKupac);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAdresaKupac);
            this.groupBox2.Controls.Add(this.txtImePrezKupac);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 107);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podatci o kupcu";
            // 
            // txtImeKorisnik
            // 
            this.txtImeKorisnik.Location = new System.Drawing.Point(97, 45);
            this.txtImeKorisnik.Name = "txtImeKorisnik";
            this.txtImeKorisnik.ReadOnly = true;
            this.txtImeKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtImeKorisnik.TabIndex = 23;
            // 
            // txtPrezimeKorisnik
            // 
            this.txtPrezimeKorisnik.Location = new System.Drawing.Point(204, 45);
            this.txtPrezimeKorisnik.Name = "txtPrezimeKorisnik";
            this.txtPrezimeKorisnik.ReadOnly = true;
            this.txtPrezimeKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtPrezimeKorisnik.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ime i prezime";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPrezimeKorisnik);
            this.groupBox3.Controls.Add(this.txtImeKorisnik);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtIDkorisnik);
            this.groupBox3.Controls.Add(this.dtpDatum);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 107);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Račun izdaje";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(102, 440);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 27;
            this.txtUkupno.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ukupni iznos";
            // 
            // frmDodajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 501);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUrediStavku);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.dgvNoveStavke);
            this.Controls.Add(this.btnDodajRačun);
            this.Name = "frmDodajRacun";
            this.Text = "Dodaj Racun";
            this.Load += new System.EventHandler(this.frmDodajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoveStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtIDkorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajRačun;
        private System.Windows.Forms.DataGridView dgvNoveStavke;
        private System.Windows.Forms.Button btnDodajStavke;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.TextBox txtIzabranaStavka;
        private System.Windows.Forms.Button btnOdabirStavke;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImePrezKupac;
        private System.Windows.Forms.TextBox txtAdresaKupac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOIBKupac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtImeKorisnik;
        private System.Windows.Forms.TextBox txtPrezimeKorisnik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdStavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn popust_stavke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label9;
    }
}