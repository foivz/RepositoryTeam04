namespace PI_PROJEKT
{
    partial class frmUrediZaposlenika
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
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txtTelefonskiBroj = new System.Windows.Forms.TextBox();
            this.txtZiroRacun = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(108, 185);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbAdmin.TabIndex = 29;
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtTelefonskiBroj
            // 
            this.txtTelefonskiBroj.Location = new System.Drawing.Point(108, 154);
            this.txtTelefonskiBroj.Name = "txtTelefonskiBroj";
            this.txtTelefonskiBroj.Size = new System.Drawing.Size(163, 20);
            this.txtTelefonskiBroj.TabIndex = 28;
            this.txtTelefonskiBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonskiBroj_KeyPress);
            // 
            // txtZiroRacun
            // 
            this.txtZiroRacun.Location = new System.Drawing.Point(108, 125);
            this.txtZiroRacun.Name = "txtZiroRacun";
            this.txtZiroRacun.Size = new System.Drawing.Size(163, 20);
            this.txtZiroRacun.TabIndex = 27;
            this.txtZiroRacun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZiroRacun_KeyPress);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(108, 96);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(163, 20);
            this.txtLozinka.TabIndex = 26;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(108, 9);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(163, 20);
            this.txtIme.TabIndex = 25;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(108, 67);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(163, 20);
            this.txtKorisnickoIme.TabIndex = 24;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(108, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(163, 20);
            this.txtPrezime.TabIndex = 23;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(17, 219);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(254, 34);
            this.btnDodajZaposlenika.TabIndex = 22;
            this.btnDodajZaposlenika.Text = "Spremi promjene";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefonski broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Žiro račun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ime";
            // 
            // frmUrediZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.txtTelefonskiBroj);
            this.Controls.Add(this.txtZiroRacun);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUrediZaposlenika";
            this.Text = "Uredi zaposlenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrediZaposlenika_FormClosed);
            this.Load += new System.EventHandler(this.frmUrediZaposlenika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox txtTelefonskiBroj;
        private System.Windows.Forms.TextBox txtZiroRacun;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}