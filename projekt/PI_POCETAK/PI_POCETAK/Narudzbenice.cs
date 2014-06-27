using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_POCETAK
{
    public partial class Narudzbenice : Form
    {
        public Narudzbenice()
        {
            InitializeComponent();
        }

        private void narudzbenicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.narudzbenicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiskaraNETDataSet);

        }

        private void Narudzbenice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiskaraNETDataSet.narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.tiskaraNETDataSet.narudzbenica);

        }
    }
}
