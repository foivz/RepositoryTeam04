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
    public partial class frmDodajZaposlenika : Form
    {
        public frmDodajZaposlenika()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            korisnici noviKorisnik = new korisnici();
            noviKorisnik.ime = txtIme.Text;
            noviKorisnik.prezime = txtPrezime.Text;
            noviKorisnik.korisnicko_ime = txtKorisnickoIme.Text;
            noviKorisnik.lozinka = txtLozinka.Text;
            noviKorisnik.ziro_racun = txtZiroRacun.Text;
            noviKorisnik.tel_broj = txtTelefonskiBroj.Text;

            if (cbAdmin.Checked)
            {
                noviKorisnik.status = 1;
            }
            else
            {
                noviKorisnik.status = 2;
            }

            baza.korisnici.Add(noviKorisnik);
            baza.SaveChanges();
            MessageBox.Show("Novi zaposlenik dodan!");
            this.Close();          
        }

        private void frmDodajZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmZaposlenici forma = new frmZaposlenici();
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        private void txtZiroRacun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 )
            {
                e.Handled = true;
            }
        }

        private void txtTelefonskiBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 47)
            {
                e.Handled = true;
            }
        }
    }
}
