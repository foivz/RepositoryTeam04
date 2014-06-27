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
    public partial class Izdatnice : Form
    {
        public Izdatnice()
        {
            InitializeComponent();
        }

        private void izdatnicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.izdatnicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiskaraNETDataSet);

        }

        private void Izdatnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiskaraNETDataSet.izdatnica' table. You can move, or remove it, as needed.
            this.izdatnicaTableAdapter.Fill(this.tiskaraNETDataSet.izdatnica);

        }
    }
}
