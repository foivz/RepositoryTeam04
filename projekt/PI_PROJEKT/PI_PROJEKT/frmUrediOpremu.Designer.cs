namespace PI_PROJEKT
{
    partial class frmUrediOpremu
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
            this.btnUrediOpremu = new System.Windows.Forms.Button();
            this.txtOpisOpreme = new System.Windows.Forms.TextBox();
            this.txtNazivOpreme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUrediOpremu
            // 
            this.btnUrediOpremu.Location = new System.Drawing.Point(13, 167);
            this.btnUrediOpremu.Name = "btnUrediOpremu";
            this.btnUrediOpremu.Size = new System.Drawing.Size(311, 34);
            this.btnUrediOpremu.TabIndex = 10;
            this.btnUrediOpremu.Text = "Spremi promjene";
            this.btnUrediOpremu.UseVisualStyleBackColor = true;
            this.btnUrediOpremu.Click += new System.EventHandler(this.btnUrediOpremu_Click);
            // 
            // txtOpisOpreme
            // 
            this.txtOpisOpreme.Location = new System.Drawing.Point(66, 53);
            this.txtOpisOpreme.Multiline = true;
            this.txtOpisOpreme.Name = "txtOpisOpreme";
            this.txtOpisOpreme.Size = new System.Drawing.Size(258, 92);
            this.txtOpisOpreme.TabIndex = 9;
            // 
            // txtNazivOpreme
            // 
            this.txtNazivOpreme.Location = new System.Drawing.Point(66, 15);
            this.txtNazivOpreme.Name = "txtNazivOpreme";
            this.txtNazivOpreme.Size = new System.Drawing.Size(258, 20);
            this.txtNazivOpreme.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv";
            // 
            // frmUrediOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 213);
            this.Controls.Add(this.btnUrediOpremu);
            this.Controls.Add(this.txtOpisOpreme);
            this.Controls.Add(this.txtNazivOpreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUrediOpremu";
            this.Text = "Uredi opremu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrediOpremu_FormClosed);
            this.Load += new System.EventHandler(this.frmUrediOpremu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrediOpremu;
        private System.Windows.Forms.TextBox txtOpisOpreme;
        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}