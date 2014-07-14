namespace PI_PROJEKT
{
    partial class frmPregledIzdatnica
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
            this.dgvIzdatnice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStavkeIzdatnice = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzdatnice
            // 
            this.dgvIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdatnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvIzdatnice.Location = new System.Drawing.Point(12, 29);
            this.dgvIzdatnice.MultiSelect = false;
            this.dgvIzdatnice.Name = "dgvIzdatnice";
            this.dgvIzdatnice.ReadOnly = true;
            this.dgvIzdatnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzdatnice.Size = new System.Drawing.Size(364, 150);
            this.dgvIzdatnice.TabIndex = 0;
            this.dgvIzdatnice.SelectionChanged += new System.EventHandler(this.dgvIzdatnice_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID izdatnica";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Datum";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Izdao";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dgvStavkeIzdatnice
            // 
            this.dgvStavkeIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeIzdatnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvStavkeIzdatnice.Location = new System.Drawing.Point(12, 230);
            this.dgvStavkeIzdatnice.MultiSelect = false;
            this.dgvStavkeIzdatnice.Name = "dgvStavkeIzdatnice";
            this.dgvStavkeIzdatnice.ReadOnly = true;
            this.dgvStavkeIzdatnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeIzdatnice.Size = new System.Drawing.Size(364, 150);
            this.dgvStavkeIzdatnice.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID artikla";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Naziv";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Količina";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis izdanih izdatnica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stavke izabrane izdatnice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generiraj PDF za izabranu izdatnicu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPregledIzdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavkeIzdatnice);
            this.Controls.Add(this.dgvIzdatnice);
            this.Name = "frmPregledIzdatnica";
            this.Text = "Pregled izdatnica";
            this.Load += new System.EventHandler(this.PregledIzdatnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzdatnice;
        private System.Windows.Forms.DataGridView dgvStavkeIzdatnice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
    }
}