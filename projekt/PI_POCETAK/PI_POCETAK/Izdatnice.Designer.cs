namespace PI_POCETAK
{
    partial class Izdatnice
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
            this.izdatnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdatnicaTableAdapter = new PI_POCETAK.tiskaraNETDataSetTableAdapters.izdatnicaTableAdapter();
            this.tableAdapterManager = new PI_POCETAK.tiskaraNETDataSetTableAdapters.TableAdapterManager();
            this.izdatnicaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetaljiIzdatnice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tiskaraNETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tiskaraNETDataSet
            // 
            this.tiskaraNETDataSet.DataSetName = "tiskaraNETDataSet";
            this.tiskaraNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdatnicaBindingSource
            // 
            this.izdatnicaBindingSource.DataMember = "izdatnica";
            this.izdatnicaBindingSource.DataSource = this.tiskaraNETDataSet;
            // 
            // izdatnicaTableAdapter
            // 
            this.izdatnicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.izdatnicaTableAdapter = this.izdatnicaTableAdapter;
            this.tableAdapterManager.korisniciTableAdapter = null;
            this.tableAdapterManager.narudzbenicaTableAdapter = null;
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
            // izdatnicaDataGridView
            // 
            this.izdatnicaDataGridView.AutoGenerateColumns = false;
            this.izdatnicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izdatnicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.izdatnicaDataGridView.DataSource = this.izdatnicaBindingSource;
            this.izdatnicaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.izdatnicaDataGridView.Name = "izdatnicaDataGridView";
            this.izdatnicaDataGridView.Size = new System.Drawing.Size(344, 220);
            this.izdatnicaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_izdatnica";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_izdatnica";
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
            // btnDetaljiIzdatnice
            // 
            this.btnDetaljiIzdatnice.Location = new System.Drawing.Point(12, 262);
            this.btnDetaljiIzdatnice.Name = "btnDetaljiIzdatnice";
            this.btnDetaljiIzdatnice.Size = new System.Drawing.Size(344, 23);
            this.btnDetaljiIzdatnice.TabIndex = 3;
            this.btnDetaljiIzdatnice.Text = "Prikaži detalje";
            this.btnDetaljiIzdatnice.UseVisualStyleBackColor = true;
            // 
            // Izdatnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 317);
            this.Controls.Add(this.btnDetaljiIzdatnice);
            this.Controls.Add(this.izdatnicaDataGridView);
            this.Name = "Izdatnice";
            this.Text = "Izdatnice";
            this.Load += new System.EventHandler(this.Izdatnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiskaraNETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tiskaraNETDataSet tiskaraNETDataSet;
        private System.Windows.Forms.BindingSource izdatnicaBindingSource;
        private tiskaraNETDataSetTableAdapters.izdatnicaTableAdapter izdatnicaTableAdapter;
        private tiskaraNETDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView izdatnicaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnDetaljiIzdatnice;
    }
}