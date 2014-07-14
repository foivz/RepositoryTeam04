namespace PI_PROJEKT
{
    partial class frmDodajNarudzbenicu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezimeKorisnik = new System.Windows.Forms.TextBox();
            this.txtImeKorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDkorisnik = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZiroRacun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntOdaberiPartnera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dgvNoveStavke = new System.Windows.Forms.DataGridView();
            this.ID_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajNarudžbenicu = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtIdStavke = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNazivStavke = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbSalji = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoveStavke)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPrezimeKorisnik);
            this.groupBox3.Controls.Add(this.txtImeKorisnik);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtIDkorisnik);
            this.groupBox3.Controls.Add(this.dtpDatum);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 107);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Narudžbenicu izdaje";
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
            // txtPrezimeKorisnik
            // 
            this.txtPrezimeKorisnik.Location = new System.Drawing.Point(204, 45);
            this.txtPrezimeKorisnik.Name = "txtPrezimeKorisnik";
            this.txtPrezimeKorisnik.ReadOnly = true;
            this.txtPrezimeKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtPrezimeKorisnik.TabIndex = 24;
            // 
            // txtImeKorisnik
            // 
            this.txtImeKorisnik.Location = new System.Drawing.Point(97, 45);
            this.txtImeKorisnik.Name = "txtImeKorisnik";
            this.txtImeKorisnik.ReadOnly = true;
            this.txtImeKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtImeKorisnik.TabIndex = 23;
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
            // txtIDkorisnik
            // 
            this.txtIDkorisnik.Location = new System.Drawing.Point(97, 19);
            this.txtIDkorisnik.Name = "txtIDkorisnik";
            this.txtIDkorisnik.ReadOnly = true;
            this.txtIDkorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtIDkorisnik.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(97, 71);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(207, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtZiroRacun);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bntOdaberiPartnera);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIDPP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNaziv);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 160);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podatci o partneru";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(120, 123);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(156, 20);
            this.txtTel.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Telefonski broj";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtZiroRacun
            // 
            this.txtZiroRacun.Location = new System.Drawing.Point(120, 71);
            this.txtZiroRacun.Name = "txtZiroRacun";
            this.txtZiroRacun.ReadOnly = true;
            this.txtZiroRacun.Size = new System.Drawing.Size(156, 20);
            this.txtZiroRacun.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Žiro račun";
            // 
            // bntOdaberiPartnera
            // 
            this.bntOdaberiPartnera.Location = new System.Drawing.Point(243, 13);
            this.bntOdaberiPartnera.Name = "bntOdaberiPartnera";
            this.bntOdaberiPartnera.Size = new System.Drawing.Size(33, 23);
            this.bntOdaberiPartnera.TabIndex = 24;
            this.bntOdaberiPartnera.Text = "...";
            this.bntOdaberiPartnera.UseVisualStyleBackColor = true;
            this.bntOdaberiPartnera.Click += new System.EventHandler(this.bntOdaberiPartnera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID partnera";
            // 
            // txtIDPP
            // 
            this.txtIDPP.Location = new System.Drawing.Point(120, 15);
            this.txtIDPP.Name = "txtIDPP";
            this.txtIDPP.ReadOnly = true;
            this.txtIDPP.Size = new System.Drawing.Size(117, 20);
            this.txtIDPP.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(120, 41);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(159, 20);
            this.txtNaziv.TabIndex = 16;
            // 
            // btnUrediStavku
            // 
            this.btnUrediStavku.Enabled = false;
            this.btnUrediStavku.Location = new System.Drawing.Point(488, 455);
            this.btnUrediStavku.Name = "btnUrediStavku";
            this.btnUrediStavku.Size = new System.Drawing.Size(75, 23);
            this.btnUrediStavku.TabIndex = 30;
            this.btnUrediStavku.Text = "Uredi";
            this.btnUrediStavku.UseVisualStyleBackColor = true;
            this.btnUrediStavku.Click += new System.EventHandler(this.btnUrediStavku_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Enabled = false;
            this.btnObrisiStavku.Location = new System.Drawing.Point(575, 455);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStavku.TabIndex = 29;
            this.btnObrisiStavku.Text = "Obriši";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // dgvNoveStavke
            // 
            this.dgvNoveStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoveStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_stavke,
            this.naziv_stavke,
            this.kolicina_stavke});
            this.dgvNoveStavke.Location = new System.Drawing.Point(25, 280);
            this.dgvNoveStavke.Name = "dgvNoveStavke";
            this.dgvNoveStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoveStavke.Size = new System.Drawing.Size(647, 169);
            this.dgvNoveStavke.TabIndex = 28;
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
            // kolicina_stavke
            // 
            this.kolicina_stavke.HeaderText = "Količina";
            this.kolicina_stavke.Name = "kolicina_stavke";
            this.kolicina_stavke.ReadOnly = true;
            // 
            // btnDodajNarudžbenicu
            // 
            this.btnDodajNarudžbenicu.Location = new System.Drawing.Point(488, 492);
            this.btnDodajNarudžbenicu.Name = "btnDodajNarudžbenicu";
            this.btnDodajNarudžbenicu.Size = new System.Drawing.Size(162, 23);
            this.btnDodajNarudžbenicu.TabIndex = 27;
            this.btnDodajNarudžbenicu.Text = "Dodaj narudžbenicu";
            this.btnDodajNarudžbenicu.UseVisualStyleBackColor = true;
            this.btnDodajNarudžbenicu.Click += new System.EventHandler(this.btnDodajNarudžbenicu_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtIdStavke);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtKolicina);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.txtNazivStavke);
            this.groupBox5.Location = new System.Drawing.Point(25, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(647, 92);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodavanje stavki";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(69, 54);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(257, 20);
            this.txtKolicina.TabIndex = 11;
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dodaj stavku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNazivStavke
            // 
            this.txtNazivStavke.Location = new System.Drawing.Point(69, 19);
            this.txtNazivStavke.Name = "txtNazivStavke";
            this.txtNazivStavke.ReadOnly = true;
            this.txtNazivStavke.Size = new System.Drawing.Size(257, 20);
            this.txtNazivStavke.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(473, 882);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Uredi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(560, 882);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Obriši";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(473, 911);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Dodaj primku";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cbSalji
            // 
            this.cbSalji.AutoSize = true;
            this.cbSalji.Location = new System.Drawing.Point(240, 496);
            this.cbSalji.Name = "cbSalji";
            this.cbSalji.Size = new System.Drawing.Size(242, 17);
            this.cbSalji.TabIndex = 39;
            this.cbSalji.Text = "Odmah pošalji narudžbenicu na navedeni mail";
            this.cbSalji.UseVisualStyleBackColor = true;
            // 
            // frmDodajNarudzbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 519);
            this.Controls.Add(this.cbSalji);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUrediStavku);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.dgvNoveStavke);
            this.Controls.Add(this.btnDodajNarudžbenicu);
            this.Name = "frmDodajNarudzbenicu";
            this.Text = "Dodaj Narudzbenicu";
            this.Load += new System.EventHandler(this.frmDodajNarudzbenicu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoveStavke)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrezimeKorisnik;
        private System.Windows.Forms.TextBox txtImeKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDkorisnik;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.DataGridView dgvNoveStavke;
        private System.Windows.Forms.Button btnDodajNarudžbenicu;
        private System.Windows.Forms.Button bntOdaberiPartnera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtIdStavke;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNazivStavke;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZiroRacun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina_stavke;
        private System.Windows.Forms.CheckBox cbSalji;
    }
}