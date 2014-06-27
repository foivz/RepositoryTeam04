namespace PI_POCETAK
{
    partial class Narudzbenice
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
            this.components = new System.ComponentModel.Container();
            this.tiskaraNETDataSet = new PI_POCETAK.tiskaraNETDataSet();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaTableAdapter = new PI_POCETAK.tiskaraNETDataSetTableAdapters.narudzbenicaTableAdapter();
            this.tableAdapterManager = new PI_POCETAK.tiskaraNETDataSetTableAdapters.TableAdapterManager();
            this.narudzbenicaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetaljiNarudzbenica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tiskaraNETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tiskaraNETDataSet
            // 
            this.tiskaraNETDataSet.DataSetName = "tiskaraNETDataSet";
            this.tiskaraNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataMember = "narudzbenica";
            this.narudzbenicaBindingSource.DataSource = this.tiskaraNETDataSet;
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.izdatnicaTableAdapter = null;
            this.tableAdapterManager.korisniciTableAdapter = null;
            this.tableAdapterManager.narudzbenicaTableAdapter = this.narudzbenicaTableAdapter;
            this.tableAdapterManager.opremaTableAdapter = null;
            this.tableAdapterManager.poslovni_partnerTableAdapter = null;
            this.tableAdapterManager.primkaTableAdapter = null;
            this.tableAdapterManager.racunTableAdapter = null;
            this.tableAdapterManager.stavke_izdatniceTableAdapter = null;
            this.tableAdapterManager.stavke_narudzbeniceTableAdapter = null;
            this.tableAdapterManager.stavke_primkeTableAdapter = null;
            this.tableAdapterManager.stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PI_POCETAK.tiskaraNETDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vrsta_artiklaTableAdapter = null;
            // 
            // narudzbenicaDataGridView
            // 
            this.narudzbenicaDataGridView.AutoGenerateColumns = false;
            this.narudzbenicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbenicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.narudzbenicaDataGridView.DataSource = this.narudzbenicaBindingSource;
            this.narudzbenicaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.narudzbenicaDataGridView.Name = "narudzbenicaDataGridView";
            this.narudzbenicaDataGridView.Size = new System.Drawing.Size(443, 198);
            this.narudzbenicaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_narudzbenica";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_narudzbenica";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_korisnik";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_korisnik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_poslovni_partner";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_poslovni_partner";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnDetaljiNarudzbenica
            // 
            this.btnDetaljiNarudzbenica.Location = new System.Drawing.Point(12, 231);
            this.btnDetaljiNarudzbenica.Name = "btnDetaljiNarudzbenica";
            this.btnDetaljiNarudzbenica.Size = new System.Drawing.Size(443, 23);
            this.btnDetaljiNarudzbenica.TabIndex = 2;
            this.btnDetaljiNarudzbenica.Text = "Prikaži detalje";
            this.btnDetaljiNarudzbenica.UseVisualStyleBackColor = true;
            // 
            // Narudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 278);
            this.Controls.Add(this.btnDetaljiNarudzbenica);
            this.Controls.Add(this.narudzbenicaDataGridView);
            this.Name = "Narudzbenice";
            this.Text = "Narudzbenice";
            this.Load += new System.EventHandler(this.Narudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiskaraNETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tiskaraNETDataSet tiskaraNETDataSet;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private tiskaraNETDataSetTableAdapters.narudzbenicaTableAdapter narudzbenicaTableAdapter;
        private tiskaraNETDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView narudzbenicaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnDetaljiNarudzbenica;
    }
}