namespace PI_PROJEKT
{
    partial class frmUrediPartnera
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
            this.btnPromijeniPartnera = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefonskiBroj = new System.Windows.Forms.TextBox();
            this.txtZiroRacun = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPromijeniPartnera
            // 
            this.btnPromijeniPartnera.Location = new System.Drawing.Point(19, 177);
            this.btnPromijeniPartnera.Name = "btnPromijeniPartnera";
            this.btnPromijeniPartnera.Size = new System.Drawing.Size(257, 34);
            this.btnPromijeniPartnera.TabIndex = 17;
            this.btnPromijeniPartnera.Text = "Promijeni";
            this.btnPromijeniPartnera.UseVisualStyleBackColor = true;
            this.btnPromijeniPartnera.Click += new System.EventHandler(this.btnPromijeniPartnera_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtTelefonskiBroj
            // 
            this.txtTelefonskiBroj.Location = new System.Drawing.Point(107, 98);
            this.txtTelefonskiBroj.Name = "txtTelefonskiBroj";
            this.txtTelefonskiBroj.Size = new System.Drawing.Size(169, 20);
            this.txtTelefonskiBroj.TabIndex = 15;
            this.txtTelefonskiBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonskiBroj_KeyPress);
            // 
            // txtZiroRacun
            // 
            this.txtZiroRacun.Location = new System.Drawing.Point(107, 55);
            this.txtZiroRacun.Name = "txtZiroRacun";
            this.txtZiroRacun.Size = new System.Drawing.Size(169, 20);
            this.txtZiroRacun.TabIndex = 14;
            this.txtZiroRacun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZiroRacun_KeyPress);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(107, 12);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(169, 20);
            this.txtNaziv.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefonski broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Žiro račun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv";
            // 
            // frmUrediPartnera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 224);
            this.Controls.Add(this.btnPromijeniPartnera);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefonskiBroj);
            this.Controls.Add(this.txtZiroRacun);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUrediPartnera";
            this.Text = "Uredi partnera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrediPartnera_FormClosed);
            this.Load += new System.EventHandler(this.frmUrediPartnera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromijeniPartnera;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonskiBroj;
        private System.Windows.Forms.TextBox txtZiroRacun;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}