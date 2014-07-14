namespace PI_PROJEKT
{
    partial class frmDodajIzdatnicu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdStavke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnOdabirStavke = new System.Windows.Forms.Button();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            this.txtIzabranaStavka = new System.Windows.Forms.TextBox();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dgvNoveStavke = new System.Windows.Forms.DataGridView();
            this.ID_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina_stavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajRačun = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoveStavke)).BeginInit();
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
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 79);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izdatnicu izdaje";
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
            this.dtpDatum.Location = new System.Drawing.Point(415, 19);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(207, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdStavke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.btnOdabirStavke);
            this.groupBox1.Controls.Add(this.btnDodajStavke);
            this.groupBox1.Controls.Add(this.txtIzabranaStavka);
            this.groupBox1.Location = new System.Drawing.Point(17, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 92);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje stavki";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(69, 54);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(257, 20);
            this.txtKolicina.TabIndex = 11;
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
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
            // btnDodajStavke
            // 
            this.btnDodajStavke.Location = new System.Drawing.Point(401, 35);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(234, 39);
            this.btnDodajStavke.TabIndex = 6;
            this.btnDodajStavke.Text = "Dodaj stavku";
            this.btnDodajStavke.UseVisualStyleBackColor = true;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // txtIzabranaStavka
            // 
            this.txtIzabranaStavka.Location = new System.Drawing.Point(69, 19);
            this.txtIzabranaStavka.Name = "txtIzabranaStavka";
            this.txtIzabranaStavka.ReadOnly = true;
            this.txtIzabranaStavka.Size = new System.Drawing.Size(257, 20);
            this.txtIzabranaStavka.TabIndex = 9;
            // 
            // btnUrediStavku
            // 
            this.btnUrediStavku.Enabled = false;
            this.btnUrediStavku.Location = new System.Drawing.Point(490, 375);
            this.btnUrediStavku.Name = "btnUrediStavku";
            this.btnUrediStavku.Size = new System.Drawing.Size(75, 23);
            this.btnUrediStavku.TabIndex = 37;
            this.btnUrediStavku.Text = "Uredi";
            this.btnUrediStavku.UseVisualStyleBackColor = true;
            this.btnUrediStavku.Click += new System.EventHandler(this.btnUrediStavku_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Enabled = false;
            this.btnObrisiStavku.Location = new System.Drawing.Point(577, 375);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStavku.TabIndex = 36;
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
            this.dgvNoveStavke.Location = new System.Drawing.Point(17, 195);
            this.dgvNoveStavke.Name = "dgvNoveStavke";
            this.dgvNoveStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoveStavke.Size = new System.Drawing.Size(647, 169);
            this.dgvNoveStavke.TabIndex = 35;
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
            // btnDodajRačun
            // 
            this.btnDodajRačun.Location = new System.Drawing.Point(490, 404);
            this.btnDodajRačun.Name = "btnDodajRačun";
            this.btnDodajRačun.Size = new System.Drawing.Size(162, 23);
            this.btnDodajRačun.TabIndex = 34;
            this.btnDodajRačun.Text = "Dodaj izdatnicu";
            this.btnDodajRačun.UseVisualStyleBackColor = true;
            this.btnDodajRačun.Click += new System.EventHandler(this.btnDodajRačun_Click);
            // 
            // frmDodajIzdatnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUrediStavku);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.dgvNoveStavke);
            this.Controls.Add(this.btnDodajRačun);
            this.Name = "frmDodajIzdatnicu";
            this.Text = "Dodaj Izdatnicu";
            this.Load += new System.EventHandler(this.frmDodajIzdatnicu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoveStavke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrezimeKorisnik;
        private System.Windows.Forms.TextBox txtImeKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDkorisnik;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdStavke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnOdabirStavke;
        private System.Windows.Forms.Button btnDodajStavke;
        private System.Windows.Forms.TextBox txtIzabranaStavka;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.DataGridView dgvNoveStavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina_stavke;
        private System.Windows.Forms.Button btnDodajRačun;
    }
}