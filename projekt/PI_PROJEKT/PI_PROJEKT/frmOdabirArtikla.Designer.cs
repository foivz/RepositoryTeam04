namespace PI_PROJEKT
{
    partial class frmOdabirArtikla
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnUbaciStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(12, 12);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(426, 150);
            this.dgvArtikli.TabIndex = 0;
            // 
            // btnUbaciStavku
            // 
            this.btnUbaciStavku.Location = new System.Drawing.Point(12, 168);
            this.btnUbaciStavku.Name = "btnUbaciStavku";
            this.btnUbaciStavku.Size = new System.Drawing.Size(426, 23);
            this.btnUbaciStavku.TabIndex = 1;
            this.btnUbaciStavku.Text = "Ubaci stavku";
            this.btnUbaciStavku.UseVisualStyleBackColor = true;
            this.btnUbaciStavku.Click += new System.EventHandler(this.btnUbaciStavku_Click);
            // 
            // frmOdabirArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 199);
            this.Controls.Add(this.btnUbaciStavku);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "frmOdabirArtikla";
            this.Text = "Odabir Artikla";
            this.Load += new System.EventHandler(this.frmOdabirArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnUbaciStavku;
    }
}