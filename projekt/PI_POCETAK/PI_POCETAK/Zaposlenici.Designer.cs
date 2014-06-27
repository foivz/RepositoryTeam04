namespace PI_POCETAK
{
    partial class Zaposlenici
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
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciTableAdapter = new PI_POCETAK.tiskaraNETDataSetTableAdapters.korisniciTableAdapter();
            this.tableAdapterManager = new PI_POCETAK.tiskaraNETDataSetTableAdapters.TableAdapterManager();
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZaposlenikDodaj = new System.Windows.Forms.Button();
            this.btnZaposlenikUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tiskaraNETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tiskaraNETDataSet
            // 
            this.tiskaraNETDataSet.DataSetName = "tiskaraNETDataSet";
            this.tiskaraNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "korisnici";
            this.korisniciBindingSource.DataSource = this.tiskaraNETDataSet;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.izdatnicaTableAdapter = null;
            this.tableAdapterManager.korisniciTableAdapter = this.korisniciTableAdapter;
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
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.AutoGenerateColumns = false;
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.korisniciDataGridView.DataSource = this.korisniciBindingSource;
            this.korisniciDataGridView.Location = new System.Drawing.Point(12, 28);
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.Size = new System.Drawing.Size(844, 258);
            this.korisniciDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_korisnik";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_korisnik";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lozinka";
            this.dataGridViewTextBoxColumn4.HeaderText = "lozinka";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ziro_racun";
            this.dataGridViewTextBoxColumn5.HeaderText = "ziro_racun";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tel_broj";
            this.dataGridViewTextBoxColumn6.HeaderText = "tel_broj";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "korisnicko_ime";
            this.dataGridViewTextBoxColumn7.HeaderText = "korisnicko_ime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn8.HeaderText = "status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnZaposlenikDodaj
            // 
            this.btnZaposlenikDodaj.Location = new System.Drawing.Point(781, 308);
            this.btnZaposlenikDodaj.Name = "btnZaposlenikDodaj";
            this.btnZaposlenikDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnZaposlenikDodaj.TabIndex = 2;
            this.btnZaposlenikDodaj.Text = "Dodaj";
            this.btnZaposlenikDodaj.UseVisualStyleBackColor = true;
            this.btnZaposlenikDodaj.Click += new System.EventHandler(this.btnZaposlenikDodaj_Click);
            // 
            // btnZaposlenikUredi
            // 
            this.btnZaposlenikUredi.Location = new System.Drawing.Point(690, 308);
            this.btnZaposlenikUredi.Name = "btnZaposlenikUredi";
            this.btnZaposlenikUredi.Size = new System.Drawing.Size(75, 23);
            this.btnZaposlenikUredi.TabIndex = 3;
            this.btnZaposlenikUredi.Text = "Uredi";
            this.btnZaposlenikUredi.UseVisualStyleBackColor = true;
            // 
            // Zaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 357);
            this.Controls.Add(this.btnZaposlenikUredi);
            this.Controls.Add(this.btnZaposlenikDodaj);
            this.Controls.Add(this.korisniciDataGridView);
            this.Name = "Zaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Zaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiskaraNETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tiskaraNETDataSet tiskaraNETDataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private tiskaraNETDataSetTableAdapters.korisniciTableAdapter korisniciTableAdapter;
        private tiskaraNETDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView korisniciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnZaposlenikDodaj;
        private System.Windows.Forms.Button btnZaposlenikUredi;
    }
}