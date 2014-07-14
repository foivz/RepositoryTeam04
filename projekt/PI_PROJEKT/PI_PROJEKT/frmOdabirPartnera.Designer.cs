namespace PI_PROJEKT
{
    partial class frmOdabirPartnera
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
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(12, 168);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(737, 23);
            this.btnOdaberi.TabIndex = 3;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // dgvPart
            // 
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Location = new System.Drawing.Point(12, 12);
            this.dgvPart.MultiSelect = false;
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.ReadOnly = true;
            this.dgvPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPart.Size = new System.Drawing.Size(737, 150);
            this.dgvPart.TabIndex = 2;
            // 
            // frmOdabirPartnera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 200);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvPart);
            this.Name = "frmOdabirPartnera";
            this.Text = "Odabir Partnera";
            this.Load += new System.EventHandler(this.frmOdabirPartnera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.DataGridView dgvPart;

    }
}