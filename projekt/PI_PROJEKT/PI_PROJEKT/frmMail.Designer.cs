namespace PI_PROJEKT
{
    partial class frmMail
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
            this.Smtpbox = new System.Windows.Forms.TextBox();
            this.Dodatak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tobox = new System.Windows.Forms.TextBox();
            this.Subbox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Userbox = new System.Windows.Forms.TextBox();
            this.Frombox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Posalji = new System.Windows.Forms.Button();
            this.Messagebox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvStavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIzdao = new System.Windows.Forms.TextBox();
            this.txtIdZap = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDnaru = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Smtpbox
            // 
            this.Smtpbox.Location = new System.Drawing.Point(79, 70);
            this.Smtpbox.Name = "Smtpbox";
            this.Smtpbox.Size = new System.Drawing.Size(153, 20);
            this.Smtpbox.TabIndex = 36;
            this.Smtpbox.Text = "smtp.gmail.com";
            // 
            // Dodatak
            // 
            this.Dodatak.Location = new System.Drawing.Point(79, 200);
            this.Dodatak.Name = "Dodatak";
            this.Dodatak.ReadOnly = true;
            this.Dodatak.Size = new System.Drawing.Size(409, 20);
            this.Dodatak.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Poruka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Korisničko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "SMTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Za";
            // 
            // Tobox
            // 
            this.Tobox.Location = new System.Drawing.Point(79, 44);
            this.Tobox.Name = "Tobox";
            this.Tobox.ReadOnly = true;
            this.Tobox.Size = new System.Drawing.Size(153, 20);
            this.Tobox.TabIndex = 27;
            // 
            // Subbox
            // 
            this.Subbox.Location = new System.Drawing.Point(79, 126);
            this.Subbox.Name = "Subbox";
            this.Subbox.Size = new System.Drawing.Size(479, 20);
            this.Subbox.TabIndex = 26;
            this.Subbox.Text = "Narudžbenica za Tiskaru";
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(457, 48);
            this.Passbox.Name = "Passbox";
            this.Passbox.ReadOnly = true;
            this.Passbox.Size = new System.Drawing.Size(134, 20);
            this.Passbox.TabIndex = 25;
            this.Passbox.Text = "NOVAlozinka";
            this.Passbox.UseSystemPasswordChar = true;
            // 
            // Userbox
            // 
            this.Userbox.Location = new System.Drawing.Point(457, 18);
            this.Userbox.Name = "Userbox";
            this.Userbox.ReadOnly = true;
            this.Userbox.Size = new System.Drawing.Size(134, 20);
            this.Userbox.TabIndex = 24;
            this.Userbox.Text = "fejk.tiskara@gmail.com";
            // 
            // Frombox
            // 
            this.Frombox.Location = new System.Drawing.Point(79, 18);
            this.Frombox.Name = "Frombox";
            this.Frombox.ReadOnly = true;
            this.Frombox.Size = new System.Drawing.Size(153, 20);
            this.Frombox.TabIndex = 23;
            this.Frombox.Text = "fejk.tiskara@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Od";
            // 
            // Posalji
            // 
            this.Posalji.Location = new System.Drawing.Point(494, 198);
            this.Posalji.Name = "Posalji";
            this.Posalji.Size = new System.Drawing.Size(75, 23);
            this.Posalji.TabIndex = 21;
            this.Posalji.Text = "Posalji";
            this.Posalji.UseVisualStyleBackColor = true;
            this.Posalji.Click += new System.EventHandler(this.Posalji_Click);
            // 
            // Messagebox
            // 
            this.Messagebox.Location = new System.Drawing.Point(79, 158);
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.Size = new System.Drawing.Size(479, 36);
            this.Messagebox.TabIndex = 19;
            this.Messagebox.Text = "Pozdrav! U privitku se nalazi narudžbenica. Hvala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Stavke narudžbenice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Narudžbenicu izdao";
            // 
            // dgvStavkeNarudzbenice
            // 
            this.dgvStavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvStavkeNarudzbenice.Location = new System.Drawing.Point(16, 126);
            this.dgvStavkeNarudzbenice.Name = "dgvStavkeNarudzbenice";
            this.dgvStavkeNarudzbenice.Size = new System.Drawing.Size(575, 150);
            this.dgvStavkeNarudzbenice.TabIndex = 38;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID artikla";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Naziv";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Količina";
            this.Column8.Name = "Column8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Smtpbox);
            this.groupBox1.Controls.Add(this.Dodatak);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Posalji);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tobox);
            this.groupBox1.Controls.Add(this.Subbox);
            this.groupBox1.Controls.Add(this.Passbox);
            this.groupBox1.Controls.Add(this.Userbox);
            this.groupBox1.Controls.Add(this.Frombox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Messagebox);
            this.groupBox1.Location = new System.Drawing.Point(12, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 228);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podatci za mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Dodatak";
            // 
            // txtIzdao
            // 
            this.txtIzdao.Location = new System.Drawing.Point(132, 15);
            this.txtIzdao.Name = "txtIzdao";
            this.txtIzdao.ReadOnly = true;
            this.txtIzdao.Size = new System.Drawing.Size(111, 20);
            this.txtIzdao.TabIndex = 42;
            // 
            // txtIdZap
            // 
            this.txtIdZap.Location = new System.Drawing.Point(132, 41);
            this.txtIdZap.Name = "txtIdZap";
            this.txtIdZap.ReadOnly = true;
            this.txtIdZap.Size = new System.Drawing.Size(111, 20);
            this.txtIdZap.TabIndex = 43;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(132, 67);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(111, 20);
            this.txtDatum.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Datum izdavanja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "ID zaposlenika";
            // 
            // txtIDnaru
            // 
            this.txtIDnaru.Location = new System.Drawing.Point(474, 15);
            this.txtIDnaru.Name = "txtIDnaru";
            this.txtIDnaru.ReadOnly = true;
            this.txtIDnaru.Size = new System.Drawing.Size(100, 20);
            this.txtIDnaru.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "ID narudžbenice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtIDnaru);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDatum);
            this.groupBox2.Controls.Add(this.txtIdZap);
            this.groupBox2.Controls.Add(this.txtIzdao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvStavkeNarudzbenice);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 297);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podatci narudžbenice";
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMail";
            this.Text = "Slanje maila";
            this.Load += new System.EventHandler(this.frmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Smtpbox;
        private System.Windows.Forms.TextBox Dodatak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tobox;
        private System.Windows.Forms.TextBox Subbox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.TextBox Frombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Posalji;
        private System.Windows.Forms.RichTextBox Messagebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbenice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIzdao;
        private System.Windows.Forms.TextBox txtIdZap;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDnaru;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
    }
}