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
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void korisniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiskaraNETDataSet);

        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiskaraNETDataSet.korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.tiskaraNETDataSet.korisnici);

        }

        private void btnZaposlenikDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenika dodaj = new DodajZaposlenika();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
        }
    }
}
