namespace PI_PROJEKT
{
    partial class frmPPartneri
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
            this.dgvPartneri = new System.Windows.Forms.DataGridView();
            this.btnDodajPartnera = new System.Windows.Forms.Button();
            this.btnUrediPPartnera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartneri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartneri
            // 
            this.dgvPartneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartneri.Location = new System.Drawing.Point(12, 12);
            this.dgvPartneri.MultiSelect = false;
            this.dgvPartneri.Name = "dgvPartneri";
            this.dgvPartneri.ReadOnly = true;
            this.dgvPartneri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartneri.Size = new System.Drawing.Size(773, 150);
            this.dgvPartneri.TabIndex = 0;
            // 
            // btnDodajPartnera
            // 
            this.btnDodajPartnera.Location = new System.Drawing.Point(710, 177);
            this.btnDodajPartnera.Name = "btnDodajPartnera";
            this.btnDodajPartnera.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPartnera.TabIndex = 1;
            this.btnDodajPartnera.Text = "Dodaj";
            this.btnDodajPartnera.UseVisualStyleBackColor = true;
            this.btnDodajPartnera.Click += new System.EventHandler(this.btnDodajPartnera_Click);
            // 
            // btnUrediPPartnera
            // 
            this.btnUrediPPartnera.Location = new System.Drawing.Point(607, 177);
            this.btnUrediPPartnera.Name = "btnUrediPPartnera";
            this.btnUrediPPartnera.Size = new System.Drawing.Size(75, 23);
            this.btnUrediPPartnera.TabIndex = 2;
            this.btnUrediPPartnera.Text = "Uredi";
            this.btnUrediPPartnera.UseVisualStyleBackColor = true;
            this.btnUrediPPartnera.Click += new System.EventHandler(this.btnUrediPPartnera_Click);
            // 
            // frmPPartneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 206);
            this.Controls.Add(this.btnUrediPPartnera);
            this.Controls.Add(this.btnDodajPartnera);
            this.Controls.Add(this.dgvPartneri);
            this.Name = "frmPPartneri";
            this.Text = "Poslovni Partneri";
            this.Load += new System.EventHandler(this.PPartneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartneri;
        private System.Windows.Forms.Button btnDodajPartnera;
        private System.Windows.Forms.Button btnUrediPPartnera;
    }
}