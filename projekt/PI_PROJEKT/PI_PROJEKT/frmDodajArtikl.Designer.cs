namespace PI_PROJEKT
{
    partial class frmDodajArtikl
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.cbVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOptimalna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Količina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta artikla";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(82, 6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(82, 46);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(157, 20);
            this.txtKolicina.TabIndex = 5;
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(14, 202);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(226, 34);
            this.btnDodajArtikl.TabIndex = 7;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // cbVrstaArtikla
            // 
            this.cbVrstaArtikla.FormattingEnabled = true;
            this.cbVrstaArtikla.Location = new System.Drawing.Point(83, 159);
            this.cbVrstaArtikla.Name = "cbVrstaArtikla";
            this.cbVrstaArtikla.Size = new System.Drawing.Size(157, 21);
            this.cbVrstaArtikla.TabIndex = 10;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(83, 119);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(157, 20);
            this.txtCijena.TabIndex = 12;
            this.txtCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCijena_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cijena";
            // 
            // txtOptimalna
            // 
            this.txtOptimalna.Location = new System.Drawing.Point(83, 79);
            this.txtOptimalna.Name = "txtOptimalna";
            this.txtOptimalna.Size = new System.Drawing.Size(157, 20);
            this.txtOptimalna.TabIndex = 14;
            this.txtOptimalna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOptimalna_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Optimalna";
            // 
            // frmDodajArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 258);
            this.Controls.Add(this.txtOptimalna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVrstaArtikla);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajArtikl";
            this.Text = "DodajArtikl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDodajArtikl_FormClosed);
            this.Load += new System.EventHandler(this.DodajArtikl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.ComboBox cbVrstaArtikla;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOptimalna;
        private System.Windows.Forms.Label label5;
    }
}