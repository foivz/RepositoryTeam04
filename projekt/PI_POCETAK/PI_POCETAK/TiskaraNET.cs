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
    public partial class TiskaraNET : Form
    {
        public TiskaraNET()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenici = new Zaposlenici();
            zaposlenici.MdiParent = this;
            zaposlenici.Show();
        }

        private void TiskaraNET_Load(object sender, EventArgs e)
        {

        }

        private void narudžbeniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudzbenice narudzbenica = new Narudzbenice();
            narudzbenica.MdiParent = this;
            narudzbenica.Show();
        }

        private void izdatniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izdatnice izdatnica = new Izdatnice();
            izdatnica.MdiParent = this;
            izdatnica.Show();
        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Racuni racun = new Racuni();
            racun.MdiParent = this;
            racun.Show();
        }

        private void primkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Primke primka = new Primke();
            primka.MdiParent = this;
            primka.Show();
        }
    }
}
