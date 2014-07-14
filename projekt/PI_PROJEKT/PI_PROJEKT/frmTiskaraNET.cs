using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_PROJEKT.Model;

namespace PI_PROJEKT
{
    public partial class frmTiskaraNET : Form
    {
        public frmTiskaraNET()
        {
            InitializeComponent();

        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        

        private void TiskaraNET_Load(object sender, EventArgs e)
        {
            Podatci.Klik = 0;
            Podatci.Nedostaje = "";
            tslblStanje.BackColor = Color.Green;
            tslblStanje.Text = "OK";
            foreach (var artikl in baza.artikli)
            {
                if (artikl.kolicina < artikl.optimalna)
                {
                    tslblStanje.BackColor = Color.Red;
                    tslblStanje.Text = "Nedostatak resursa";

                    Podatci.Nedostaje += artikl.id_artikli.ToString() + "|";

                }
            }

            
        }

        private void narudžbenicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPregledNarudzbenica narudzbenica = new frmPregledNarudzbenica();
            narudzbenica.MdiParent = this;
            narudzbenica.Show();
        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledRacuna racun = new frmPregledRacuna();
            racun.MdiParent = this;
            racun.Show();
        }

        private void primkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPrimki primka = new frmPregledPrimki();
            primka.MdiParent = this;
            primka.Show();
        }

        private void izdatnicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPregledIzdatnica izdatnica = new frmPregledIzdatnica();
            izdatnica.MdiParent = this;
            izdatnica.Show();
        }

        private void opremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOprema oprema = new frmOprema();
            oprema.MdiParent = this;
            oprema.Show();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenici zaposlenici = new frmZaposlenici();
            zaposlenici.MdiParent = this;
            zaposlenici.Show();
        }

        private void poslovniPartneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPPartneri partneri = new frmPPartneri();
            partneri.MdiParent = this;
            partneri.Show();
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtikli artikli = new frmArtikli();
            artikli.MdiParent = this;
            artikli.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void računToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajRacun racun = new frmDodajRacun();
            racun.MdiParent = this;
            racun.Show();
        }

        private void frmTiskaraNET_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void primkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajPrimku primka = new frmDodajPrimku();
            primka.MdiParent = this;
            primka.Show();
        }

        private void narudžbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajNarudzbenicu narudz = new frmDodajNarudzbenicu();
            narudz.MdiParent = this;
            narudz.Show();
        }

        private void izdatnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajIzdatnicu izdatnica = new frmDodajIzdatnicu();
            izdatnica.MdiParent = this;
            izdatnica.Show();
        }

        private void mailTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMail mail = new frmMail();
            mail.MdiParent = this;
            mail.Show();
        }

        private void tslblStanje_Click(object sender, EventArgs e)
        {
            Podatci.Klik = 1;
            if (tslblStanje.BackColor == Color.Red)
            {
                frmDodajNarudzbenicu forma = new frmDodajNarudzbenicu();
                forma.MdiParent = this;
                forma.Show();
            }
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "file://C:\\Users\\Andrija\\Desktop\\PI_PROJEKT\\Pomoc.chm");
            System.Diagnostics.Process.Start("Pomoc.chm");

        }

        

        private void frmTiskaraNET_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

    }
}
