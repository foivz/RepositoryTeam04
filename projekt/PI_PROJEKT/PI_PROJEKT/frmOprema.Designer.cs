namespace PI_PROJEKT
{
    partial class frmOprema
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
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            this.btnUrediOpremu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(12, 21);
            this.dgvOprema.MultiSelect = false;
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.ReadOnly = true;
            this.dgvOprema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOprema.Size = new System.Drawing.Size(663, 150);
            this.dgvOprema.TabIndex = 0;
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Enabled = false;
            this.btnDodajOpremu.Location = new System.Drawing.Point(600, 201);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajOpremu.TabIndex = 1;
            this.btnDodajOpremu.Text = "Dodaj";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // btnUrediOpremu
            // 
            this.btnUrediOpremu.Enabled = false;
            this.btnUrediOpremu.Location = new System.Drawing.Point(502, 200);
            this.btnUrediOpremu.Name = "btnUrediOpremu";
            this.btnUrediOpremu.Size = new System.Drawing.Size(75, 23);
            this.btnUrediOpremu.TabIndex = 2;
            this.btnUrediOpremu.Text = "Uredi";
            this.btnUrediOpremu.UseVisualStyleBackColor = true;
            this.btnUrediOpremu.Click += new System.EventHandler(this.btnUrediOpremu_Click);
            // 
            // frmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 262);
            this.Controls.Add(this.btnUrediOpremu);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.dgvOprema);
            this.Name = "frmOprema";
            this.Text = "Oprema";
            this.Load += new System.EventHandler(this.Oprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.Button btnUrediOpremu;
    }
}