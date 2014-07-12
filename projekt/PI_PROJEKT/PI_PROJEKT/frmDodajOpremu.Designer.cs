namespace PI_PROJEKT
{
    partial class frmDodajOpremu
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
            this.txtNazivOpreme = new System.Windows.Forms.TextBox();
            this.txtOpisOpreme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // txtNazivOpreme
            // 
            this.txtNazivOpreme.Location = new System.Drawing.Point(69, 10);
            this.txtNazivOpreme.Name = "txtNazivOpreme";
            this.txtNazivOpreme.Size = new System.Drawing.Size(258, 20);
            this.txtNazivOpreme.TabIndex = 2;
            // 
            // txtOpisOpreme
            // 
            this.txtOpisOpreme.Location = new System.Drawing.Point(69, 48);
            this.txtOpisOpreme.Multiline = true;
            this.txtOpisOpreme.Name = "txtOpisOpreme";
            this.txtOpisOpreme.Size = new System.Drawing.Size(258, 92);
            this.txtOpisOpreme.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 172);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(311, 34);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj novu opremu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmDodajOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 218);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpisOpreme);
            this.Controls.Add(this.txtNazivOpreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajOpremu";
            this.Text = "DodajOpremu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDodajOpremu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.TextBox txtOpisOpreme;
        private System.Windows.Forms.Button btnDodaj;
    }
}